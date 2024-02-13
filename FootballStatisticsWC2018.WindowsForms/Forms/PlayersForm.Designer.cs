namespace WindowsForms.Forms
{
    partial class PlayersForm
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
            this.LblFavPlayer = new System.Windows.Forms.Label();
            this.FlpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpFavPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.LblAllPlayers = new System.Windows.Forms.Label();
            this.LblFavPlayers = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFavPlayer
            // 
            this.LblFavPlayer.AutoSize = true;
            this.LblFavPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFavPlayer.Location = new System.Drawing.Point(9, 31);
            this.LblFavPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFavPlayer.Name = "LblFavPlayer";
            this.LblFavPlayer.Size = new System.Drawing.Size(503, 37);
            this.LblFavPlayer.TabIndex = 0;
            this.LblFavPlayer.Text = "Choose your three favorite players";
            // 
            // FlpAllPlayers
            // 
            this.FlpAllPlayers.AllowDrop = true;
            this.FlpAllPlayers.AutoScroll = true;
            this.FlpAllPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpAllPlayers.Location = new System.Drawing.Point(15, 138);
            this.FlpAllPlayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlpAllPlayers.Name = "FlpAllPlayers";
            this.FlpAllPlayers.Size = new System.Drawing.Size(316, 537);
            this.FlpAllPlayers.TabIndex = 1;
            this.FlpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpAllPlayers_DragDrop);
            this.FlpAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpAllPlayers_DragEnter);
            // 
            // FlpFavPlayers
            // 
            this.FlpFavPlayers.AllowDrop = true;
            this.FlpFavPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpFavPlayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.FlpFavPlayers.Location = new System.Drawing.Point(398, 138);
            this.FlpFavPlayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlpFavPlayers.Name = "FlpFavPlayers";
            this.FlpFavPlayers.Size = new System.Drawing.Size(298, 411);
            this.FlpFavPlayers.TabIndex = 2;
            this.FlpFavPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpFavPlayers_DragDrop);
            this.FlpFavPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpFavPlayers_DragEnter);
            // 
            // LblAllPlayers
            // 
            this.LblAllPlayers.AutoSize = true;
            this.LblAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAllPlayers.Location = new System.Drawing.Point(10, 99);
            this.LblAllPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAllPlayers.Name = "LblAllPlayers";
            this.LblAllPlayers.Size = new System.Drawing.Size(124, 29);
            this.LblAllPlayers.TabIndex = 0;
            this.LblAllPlayers.Text = "All players";
            // 
            // LblFavPlayers
            // 
            this.LblFavPlayers.AutoSize = true;
            this.LblFavPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFavPlayers.Location = new System.Drawing.Point(394, 99);
            this.LblFavPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFavPlayers.Name = "LblFavPlayers";
            this.LblFavPlayers.Size = new System.Drawing.Size(184, 29);
            this.LblFavPlayers.TabIndex = 0;
            this.LblFavPlayers.Text = "Favorite players";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(9, 700);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(85, 32);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 741);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblFavPlayers);
            this.Controls.Add(this.LblAllPlayers);
            this.Controls.Add(this.FlpFavPlayers);
            this.Controls.Add(this.FlpAllPlayers);
            this.Controls.Add(this.LblFavPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players Form";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFavPlayer;
        private System.Windows.Forms.FlowLayoutPanel FlpAllPlayers;
        private System.Windows.Forms.FlowLayoutPanel FlpFavPlayers;
        private System.Windows.Forms.Label LblAllPlayers;
        private System.Windows.Forms.Label LblFavPlayers;
        private System.Windows.Forms.Button BtnBack;
    }
}