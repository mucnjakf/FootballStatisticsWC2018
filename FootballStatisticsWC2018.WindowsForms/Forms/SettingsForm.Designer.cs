namespace WindowsForms.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbLang = new System.Windows.Forms.GroupBox();
            this.RbHrv = new System.Windows.Forms.RadioButton();
            this.RbEng = new System.Windows.Forms.RadioButton();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbLang
            // 
            this.GbLang.Controls.Add(this.RbHrv);
            this.GbLang.Controls.Add(this.RbEng);
            this.GbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLang.Location = new System.Drawing.Point(164, 52);
            this.GbLang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbLang.Name = "GbLang";
            this.GbLang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbLang.Size = new System.Drawing.Size(389, 132);
            this.GbLang.TabIndex = 0;
            this.GbLang.TabStop = false;
            this.GbLang.Text = "Choose your language";
            // 
            // RbHrv
            // 
            this.RbHrv.AutoSize = true;
            this.RbHrv.Location = new System.Drawing.Point(211, 53);
            this.RbHrv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbHrv.Name = "RbHrv";
            this.RbHrv.Size = new System.Drawing.Size(95, 36);
            this.RbHrv.TabIndex = 1;
            this.RbHrv.TabStop = true;
            this.RbHrv.Text = "HRV";
            this.RbHrv.UseVisualStyleBackColor = true;
            // 
            // RbEng
            // 
            this.RbEng.AutoSize = true;
            this.RbEng.Location = new System.Drawing.Point(83, 53);
            this.RbEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbEng.Name = "RbEng";
            this.RbEng.Size = new System.Drawing.Size(97, 36);
            this.RbEng.TabIndex = 0;
            this.RbEng.TabStop = true;
            this.RbEng.Text = "ENG";
            this.RbEng.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(164, 203);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(389, 70);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(12, 337);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(113, 39);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.GbLang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings Form";
            this.GbLang.ResumeLayout(false);
            this.GbLang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLang;
        private System.Windows.Forms.RadioButton RbHrv;
        private System.Windows.Forms.RadioButton RbEng;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnExit;
    }
}