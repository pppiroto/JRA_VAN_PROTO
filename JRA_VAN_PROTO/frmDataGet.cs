using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxJVDTLabLib;

namespace JRA_VAN_PROTO
{
    public partial class frmDataGet : Form
    {
        private AxJVLink jVLink = new AxJVDTLabLib.AxJVLink();
        private System.Resources.ResourceManager resources;

        public frmDataGet()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            resources = new System.Resources.ResourceManager(this.GetType());
            jVLink.Location = new System.Drawing.Point(0, 0);
            jVLink.Name = "jVLink"; 
            jVLink.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject($"{jVLink.Name}.OcxState");
            jVLink.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(jVLink);

            InitializeComponent();
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            this.cmbOption.DataSource = JVUtils.GetJVOpenOptions();
            this.cmbDataSpec.DataSource = JVUtils.GetDataSpecs();
            this.cmbHandler.DataSource = JVUtils.GetHandlers();
            this.txtFromtime.Text = "20200101000000";
            this.txtParam.Text = @"c:\work\jravan\out.txt";
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            // 結果が-100 の場合は設定が何らかのエラーでレジストリに反映できなかった
            if (this.jVLink.JVSetUIProperties() == -100)
            {
                MessageBox.Show("JV-Link 設定エラー");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var ret = jVLink.JVInit("UNKNOWN");
                Debug.WriteLine($"RET={ret}");
            } 
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetData_Click(object sender, EventArgs e)
        {
            // データ読み出し処理の一般的な流れ
            int returnCode = 0;
            int readCount = 0;
            int downloadCount = 0;

            try
            {
                // ①JVLinkﾉ初期化(JVInit)
                // JVLinkの初期化を行います。JVOpenを呼び出す前に最低1回呼び出す必要があります。 
                returnCode = this.jVLink.JVInit("UNKNOW");
                if (returnCode < 0)
                {
                    MessageBox.Show($"JVInitエラー。 RC={returnCode}");
                    return;
                }

                RecordHandler handler = JVUtils.GetHandler(this.cmbHandler.SelectedIndex);
                handler.Parameter = this.txtParam.Text;


                // ②JVDataのオープン(JVOpen) 
                // 要求に応じたデータを読み出せるように準備します。
                // 必要であればサーバーからデータをダウンロードする処理を起動します。
                // JVOpenからの戻りとしてダウンロードを行なう予定ファイル数が返されます。 

                string dataSpec = handler.GetDataSpec(((Parameter)this.cmbDataSpec.SelectedItem).Code);
                int optionFlag = ((Parameter)this.cmbOption.SelectedItem).CodeAsInt;
                string fromTime = this.txtFromtime.Text;    

                returnCode = this.jVLink.JVOpen(dataSpec, fromTime, optionFlag, ref readCount, ref downloadCount, out string lastFileTimestamp);
                if (returnCode < 0)
                {
                    MessageBox.Show($"JOpenエラー。 RC={returnCode}");
                    return;
                }

                if (readCount == 0)
                {
                    MessageBox.Show($"該当データがありません。");
                    return;
                }

                // ③ダウンロード中のプログレスバー表示(JVStatus)
                // JVOpenはダウンロードスレッドを起動するとダウンロード完了前に呼び出し側に制御を返しますので、
                // 呼び出し側はJVStatusを使ってダウンロード処理の進行状況を監視する必要があります。
                // JVStatusはダウンロード済みのファイル数を返しますので、JVOpen時のダウンロード予定ファイル数と一致した場合にダウンロード処理の完了とします。 

                int count = 0;
                while((count = this.jVLink.JVStatus()) < downloadCount)
                {
                    Debug.WriteLine($"count;{count} <= download count;{downloadCount}");

                    System.Threading.Thread.Sleep(10000);
                }

                // ④JVDataの読み出し(JVRead)
                // データを読み出します。ダウンロードスレッドがダウンロード実行中にJVReadを呼び出すとエラーとなります。

                string recordSpec = null;
                string buff = null;
                int buffSize = 1500;
                string fName = null;

                buff = new string('\0', buffSize);
                if (readCount > 0)
                {
                    using(handler.Open())
                    {
                        handler.WriteTitle();
                        while ((returnCode = this.jVLink.JVRead(out buff, out buffSize, out fName)) != 0)
                        {

                            if (returnCode > 0)
                            {
                                recordSpec = buff.Substring(0, 2);
                                handler.Read(recordSpec, buff);
                            }
                            else if (returnCode == -1)
                            {

                            }
                            else
                            {
                                MessageBox.Show($"読み込みエラー。 RC={returnCode}");
                                return;
                            }
                        }
                    }
                }

                // ⑤データ内容をテキストボックスに表示
                // 一般の競馬ソフトではこの処理の代わりにデータベースへデータを反映する処理が行なわれます。
            } 
            finally
            {
                // ⑥JVDataﾉｸﾛｰｽﾞ(JVClose) 
                // JVOpenで確保されたリソースを開放します。
                returnCode = this.jVLink.JVClose();
                Debug.WriteLine("FINISH.");
            }

        }
    }
}
