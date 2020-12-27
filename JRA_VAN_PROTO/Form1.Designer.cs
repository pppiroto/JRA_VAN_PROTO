
namespace JRA_VAN_PROTO
{
    partial class Form1
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
            this.btnThisWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "設定";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.Location = new System.Drawing.Point(93, 12);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(75, 23);
            this.btnThisWeek.TabIndex = 1;
            this.btnThisWeek.Text = "今週開催";
            this.btnThisWeek.UseVisualStyleBackColor = true;
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThisWeek);
            this.Controls.Add(this.btnSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnThisWeek;
    }
}

