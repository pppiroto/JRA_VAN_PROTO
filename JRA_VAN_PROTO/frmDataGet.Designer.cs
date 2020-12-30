
namespace JRA_VAN_PROTO
{
    partial class frmDataGet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.cmbDataSpec = new System.Windows.Forms.ComboBox();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.ldbDataSpec = new System.Windows.Forms.Label();
            this.txtFromtime = new System.Windows.Forms.TextBox();
            this.lblFromtime = new System.Windows.Forms.Label();
            this.cmbHandler = new System.Windows.Forms.ComboBox();
            this.lblHander = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "設定";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(346, 165);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "データ取得";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // cmbDataSpec
            // 
            this.cmbDataSpec.FormattingEnabled = true;
            this.cmbDataSpec.Location = new System.Drawing.Point(100, 83);
            this.cmbDataSpec.Name = "cmbDataSpec";
            this.cmbDataSpec.Size = new System.Drawing.Size(333, 23);
            this.cmbDataSpec.TabIndex = 2;
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(100, 54);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(333, 23);
            this.cmbOption.TabIndex = 3;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(13, 62);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(44, 15);
            this.lblOption.TabIndex = 4;
            this.lblOption.Text = "Option";
            // 
            // ldbDataSpec
            // 
            this.ldbDataSpec.AutoSize = true;
            this.ldbDataSpec.Location = new System.Drawing.Point(13, 92);
            this.ldbDataSpec.Name = "ldbDataSpec";
            this.ldbDataSpec.Size = new System.Drawing.Size(57, 15);
            this.ldbDataSpec.TabIndex = 5;
            this.ldbDataSpec.Text = "データ種別";
            // 
            // txtFromtime
            // 
            this.txtFromtime.Location = new System.Drawing.Point(100, 142);
            this.txtFromtime.Name = "txtFromtime";
            this.txtFromtime.Size = new System.Drawing.Size(123, 23);
            this.txtFromtime.TabIndex = 6;
            // 
            // lblFromtime
            // 
            this.lblFromtime.AutoSize = true;
            this.lblFromtime.Location = new System.Drawing.Point(12, 150);
            this.lblFromtime.Name = "lblFromtime";
            this.lblFromtime.Size = new System.Drawing.Size(67, 15);
            this.lblFromtime.TabIndex = 7;
            this.lblFromtime.Text = "開始ポイント";
            // 
            // cmbHandler
            // 
            this.cmbHandler.FormattingEnabled = true;
            this.cmbHandler.Location = new System.Drawing.Point(100, 113);
            this.cmbHandler.Name = "cmbHandler";
            this.cmbHandler.Size = new System.Drawing.Size(333, 23);
            this.cmbHandler.TabIndex = 8;
            // 
            // lblHander
            // 
            this.lblHander.AutoSize = true;
            this.lblHander.Location = new System.Drawing.Point(13, 121);
            this.lblHander.Name = "lblHander";
            this.lblHander.Size = new System.Drawing.Size(54, 15);
            this.lblHander.TabIndex = 9;
            this.lblHander.Text = "設定済み";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(100, 172);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(333, 23);
            this.txtParam.TabIndex = 10;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(13, 180);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(50, 15);
            this.lblParam.TabIndex = 11;
            this.lblParam.Text = "パラメータ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データ取得";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmDataGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 282);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.lblHander);
            this.Controls.Add(this.cmbHandler);
            this.Controls.Add(this.lblFromtime);
            this.Controls.Add(this.txtFromtime);
            this.Controls.Add(this.ldbDataSpec);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.cmbDataSpec);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDataGet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ComboBox cmbDataSpec;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label ldbDataSpec;
        private System.Windows.Forms.TextBox txtFromtime;
        private System.Windows.Forms.Label lblFromtime;
        private System.Windows.Forms.ComboBox cmbHandler;
        private System.Windows.Forms.Label lblHander;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

