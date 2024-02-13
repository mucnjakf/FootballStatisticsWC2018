namespace WindowsForms
{
    partial class StartForm
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
            this.LblGreetings = new System.Windows.Forms.Label();
            this.GbLang = new System.Windows.Forms.GroupBox();
            this.RbHrv = new System.Windows.Forms.RadioButton();
            this.RbEng = new System.Windows.Forms.RadioButton();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.GbLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGreetings
            // 
            this.LblGreetings.AutoSize = true;
            this.LblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreetings.Location = new System.Drawing.Point(34, 32);
            this.LblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGreetings.Name = "LblGreetings";
            this.LblGreetings.Size = new System.Drawing.Size(548, 44);
            this.LblGreetings.TabIndex = 0;
            this.LblGreetings.Text = "FIFA World Cup 2018 Statistics";
            // 
            // GbLang
            // 
            this.GbLang.Controls.Add(this.RbHrv);
            this.GbLang.Controls.Add(this.RbEng);
            this.GbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLang.Location = new System.Drawing.Point(160, 101);
            this.GbLang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbLang.Name = "GbLang";
            this.GbLang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbLang.Size = new System.Drawing.Size(266, 104);
            this.GbLang.TabIndex = 1;
            this.GbLang.TabStop = false;
            this.GbLang.Text = "Choose your language";
            // 
            // RbHrv
            // 
            this.RbHrv.AutoSize = true;
            this.RbHrv.Location = new System.Drawing.Point(148, 45);
            this.RbHrv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbHrv.Name = "RbHrv";
            this.RbHrv.Size = new System.Drawing.Size(77, 30);
            this.RbHrv.TabIndex = 4;
            this.RbHrv.TabStop = true;
            this.RbHrv.Text = "HRV";
            this.RbHrv.UseVisualStyleBackColor = true;
            // 
            // RbEng
            // 
            this.RbEng.AutoSize = true;
            this.RbEng.Location = new System.Drawing.Point(46, 45);
            this.RbEng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbEng.Name = "RbEng";
            this.RbEng.Size = new System.Drawing.Size(78, 30);
            this.RbEng.TabIndex = 3;
            this.RbEng.TabStop = true;
            this.RbEng.Text = "ENG";
            this.RbEng.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(9, 327);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 32);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Lime;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(160, 226);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(266, 52);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 368);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.GbLang);
            this.Controls.Add(this.LblGreetings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.GbLang.ResumeLayout(false);
            this.GbLang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreetings;
        private System.Windows.Forms.GroupBox GbLang;
        private System.Windows.Forms.RadioButton RbHrv;
        private System.Windows.Forms.RadioButton RbEng;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnStart;
    }
}