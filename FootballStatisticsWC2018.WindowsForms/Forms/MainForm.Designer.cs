namespace WindowsForms.Forms
{
    partial class MainForm
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
            this.LblChooseFT = new System.Windows.Forms.Label();
            this.CbFavTeam = new System.Windows.Forms.ComboBox();
            this.BtnPlayers = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnRankings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSaveFavTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblChooseFT
            // 
            this.LblChooseFT.AutoSize = true;
            this.LblChooseFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChooseFT.Location = new System.Drawing.Point(129, 29);
            this.LblChooseFT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblChooseFT.Name = "LblChooseFT";
            this.LblChooseFT.Size = new System.Drawing.Size(391, 37);
            this.LblChooseFT.TabIndex = 0;
            this.LblChooseFT.Text = "Choose your favorite team";
            // 
            // CbFavTeam
            // 
            this.CbFavTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFavTeam.FormattingEnabled = true;
            this.CbFavTeam.Location = new System.Drawing.Point(122, 87);
            this.CbFavTeam.Margin = new System.Windows.Forms.Padding(2);
            this.CbFavTeam.Name = "CbFavTeam";
            this.CbFavTeam.Size = new System.Drawing.Size(395, 28);
            this.CbFavTeam.TabIndex = 1;
            // 
            // BtnPlayers
            // 
            this.BtnPlayers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayers.Location = new System.Drawing.Point(122, 136);
            this.BtnPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPlayers.Name = "BtnPlayers";
            this.BtnPlayers.Size = new System.Drawing.Size(176, 57);
            this.BtnPlayers.TabIndex = 2;
            this.BtnPlayers.Text = "Players";
            this.BtnPlayers.UseVisualStyleBackColor = false;
            this.BtnPlayers.Click += new System.EventHandler(this.BtnPlayers_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(122, 244);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(394, 56);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnRankings
            // 
            this.BtnRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRankings.Location = new System.Drawing.Point(340, 136);
            this.BtnRankings.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRankings.Name = "BtnRankings";
            this.BtnRankings.Size = new System.Drawing.Size(176, 57);
            this.BtnRankings.TabIndex = 4;
            this.BtnRankings.Text = "Rankings";
            this.BtnRankings.UseVisualStyleBackColor = true;
            this.BtnRankings.Click += new System.EventHandler(this.BtnRankings_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(9, 334);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 32);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSaveFavTeam
            // 
            this.BtnSaveFavTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFavTeam.Location = new System.Drawing.Point(122, 198);
            this.BtnSaveFavTeam.Name = "BtnSaveFavTeam";
            this.BtnSaveFavTeam.Size = new System.Drawing.Size(394, 41);
            this.BtnSaveFavTeam.TabIndex = 6;
            this.BtnSaveFavTeam.Text = "Save favorite team";
            this.BtnSaveFavTeam.UseVisualStyleBackColor = true;
            this.BtnSaveFavTeam.Click += new System.EventHandler(this.BtnSaveFavTeam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSaveFavTeam);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRankings);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnPlayers);
            this.Controls.Add(this.CbFavTeam);
            this.Controls.Add(this.LblChooseFT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseFT;
        private System.Windows.Forms.ComboBox CbFavTeam;
        private System.Windows.Forms.Button BtnPlayers;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnRankings;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSaveFavTeam;
    }
}