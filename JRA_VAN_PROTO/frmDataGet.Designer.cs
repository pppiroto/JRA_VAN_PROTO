
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.lblHander = new System.Windows.Forms.Label();
            this.cmbHandler = new System.Windows.Forms.ComboBox();
            this.lblFromtime = new System.Windows.Forms.Label();
            this.txtFromtime = new System.Windows.Forms.TextBox();
            this.ldbDataSpec = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lstDataspec = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnDbInsert = new System.Windows.Forms.Button();
            this.txtDbFilename = new System.Windows.Forms.TextBox();
            this.lblDbFilename = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnGetData.Location = new System.Drawing.Point(352, 262);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "データ取得";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParam);
            this.groupBox1.Controls.Add(this.txtParam);
            this.groupBox1.Controls.Add(this.lblHander);
            this.groupBox1.Controls.Add(this.cmbHandler);
            this.groupBox1.Controls.Add(this.lblFromtime);
            this.groupBox1.Controls.Add(this.txtFromtime);
            this.groupBox1.Controls.Add(this.ldbDataSpec);
            this.groupBox1.Controls.Add(this.lblOption);
            this.groupBox1.Controls.Add(this.cmbOption);
            this.groupBox1.Controls.Add(this.lstDataspec);
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 295);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データ取得";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(10, 219);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(50, 15);
            this.lblParam.TabIndex = 21;
            this.lblParam.Text = "パラメータ";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(94, 219);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(333, 23);
            this.txtParam.TabIndex = 20;
            // 
            // lblHander
            // 
            this.lblHander.AutoSize = true;
            this.lblHander.Location = new System.Drawing.Point(10, 153);
            this.lblHander.Name = "lblHander";
            this.lblHander.Size = new System.Drawing.Size(54, 15);
            this.lblHander.TabIndex = 19;
            this.lblHander.Text = "設定済み";
            // 
            // cmbHandler
            // 
            this.cmbHandler.FormattingEnabled = true;
            this.cmbHandler.Location = new System.Drawing.Point(97, 153);
            this.cmbHandler.Name = "cmbHandler";
            this.cmbHandler.Size = new System.Drawing.Size(330, 23);
            this.cmbHandler.TabIndex = 18;
            // 
            // lblFromtime
            // 
            this.lblFromtime.AutoSize = true;
            this.lblFromtime.Location = new System.Drawing.Point(8, 182);
            this.lblFromtime.Name = "lblFromtime";
            this.lblFromtime.Size = new System.Drawing.Size(67, 15);
            this.lblFromtime.TabIndex = 17;
            this.lblFromtime.Text = "開始ポイント";
            // 
            // txtFromtime
            // 
            this.txtFromtime.Location = new System.Drawing.Point(97, 182);
            this.txtFromtime.Name = "txtFromtime";
            this.txtFromtime.Size = new System.Drawing.Size(123, 23);
            this.txtFromtime.TabIndex = 16;
            // 
            // ldbDataSpec
            // 
            this.ldbDataSpec.AutoSize = true;
            this.ldbDataSpec.Location = new System.Drawing.Point(7, 57);
            this.ldbDataSpec.Name = "ldbDataSpec";
            this.ldbDataSpec.Size = new System.Drawing.Size(57, 15);
            this.ldbDataSpec.TabIndex = 15;
            this.ldbDataSpec.Text = "データ種別";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(6, 19);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(44, 15);
            this.lblOption.TabIndex = 14;
            this.lblOption.Text = "Option";
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(97, 22);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(330, 23);
            this.cmbOption.TabIndex = 13;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // lstDataspec
            // 
            this.lstDataspec.FormattingEnabled = true;
            this.lstDataspec.ItemHeight = 15;
            this.lstDataspec.Location = new System.Drawing.Point(97, 51);
            this.lstDataspec.Name = "lstDataspec";
            this.lstDataspec.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDataspec.Size = new System.Drawing.Size(330, 94);
            this.lstDataspec.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateTable);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.lblUser);
            this.groupBox2.Controls.Add(this.txtDatabase);
            this.groupBox2.Controls.Add(this.lblDatabase);
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.lblHost);
            this.groupBox2.Controls.Add(this.btnDbInsert);
            this.groupBox2.Controls.Add(this.txtDbFilename);
            this.groupBox2.Controls.Add(this.lblDbFilename);
            this.groupBox2.Location = new System.Drawing.Point(457, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 295);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DB登録";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(139, 23);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(65, 89);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(139, 23);
            this.txtUser.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(65, 58);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(140, 23);
            this.txtDatabase.TabIndex = 6;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(6, 57);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(55, 15);
            this.lblDatabase.TabIndex = 5;
            this.lblDatabase.Text = "Dabatase";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(65, 29);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(185, 23);
            this.txtHost.TabIndex = 4;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(7, 29);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(37, 15);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "HOST";
            // 
            // btnDbInsert
            // 
            this.btnDbInsert.Location = new System.Drawing.Point(175, 262);
            this.btnDbInsert.Name = "btnDbInsert";
            this.btnDbInsert.Size = new System.Drawing.Size(75, 23);
            this.btnDbInsert.TabIndex = 2;
            this.btnDbInsert.Text = "DB登録";
            this.btnDbInsert.UseVisualStyleBackColor = true;
            this.btnDbInsert.Click += new System.EventHandler(this.btnDbInsert_Click);
            // 
            // txtDbFilename
            // 
            this.txtDbFilename.Location = new System.Drawing.Point(7, 216);
            this.txtDbFilename.Name = "txtDbFilename";
            this.txtDbFilename.Size = new System.Drawing.Size(244, 23);
            this.txtDbFilename.TabIndex = 1;
            // 
            // lblDbFilename
            // 
            this.lblDbFilename.AutoSize = true;
            this.lblDbFilename.Location = new System.Drawing.Point(7, 197);
            this.lblDbFilename.Name = "lblDbFilename";
            this.lblDbFilename.Size = new System.Drawing.Size(53, 15);
            this.lblDbFilename.TabIndex = 0;
            this.lblDbFilename.Text = "ファイル名";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(7, 262);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTable.TabIndex = 11;
            this.btnCreateTable.Text = "テーブル作成";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // frmDataGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDataGet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDataspec;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label lblHander;
        private System.Windows.Forms.ComboBox cmbHandler;
        private System.Windows.Forms.Label lblFromtime;
        private System.Windows.Forms.TextBox txtFromtime;
        private System.Windows.Forms.Label ldbDataSpec;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDbFilename;
        private System.Windows.Forms.TextBox txtDbFilename;
        private System.Windows.Forms.Button btnDbInsert;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreateTable;
    }
}

