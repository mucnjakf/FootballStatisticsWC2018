namespace WindowsForms.Forms
{
    partial class RankingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingsForm));
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblRankings = new System.Windows.Forms.Label();
            this.LblPlayerRank = new System.Windows.Forms.Label();
            this.LblMatchRank = new System.Windows.Forms.Label();
            this.LbNOVPM = new System.Windows.Forms.ListBox();
            this.LblNOVPM = new System.Windows.Forms.Label();
            this.TcPlayerRankings = new System.Windows.Forms.TabControl();
            this.TpGoals = new System.Windows.Forms.TabPage();
            this.LbGoals = new System.Windows.Forms.ListBox();
            this.TpYellowCards = new System.Windows.Forms.TabPage();
            this.LbYellowCards = new System.Windows.Forms.ListBox();
            this.BtnPrintNumberOfVisitors = new System.Windows.Forms.Button();
            this.printDocumentAttendance = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.BtnPrintGoals = new System.Windows.Forms.Button();
            this.printDocumentGoals = new System.Drawing.Printing.PrintDocument();
            this.printDocumentYellowCards = new System.Drawing.Printing.PrintDocument();
            this.BtnPrintYellowCards = new System.Windows.Forms.Button();
            this.TcPlayerRankings.SuspendLayout();
            this.TpGoals.SuspendLayout();
            this.TpYellowCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(15, 850);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 39);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblRankings
            // 
            this.LblRankings.AutoSize = true;
            this.LblRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRankings.Location = new System.Drawing.Point(12, 18);
            this.LblRankings.Name = "LblRankings";
            this.LblRankings.Size = new System.Drawing.Size(203, 51);
            this.LblRankings.TabIndex = 5;
            this.LblRankings.Text = "Rankings";
            // 
            // LblPlayerRank
            // 
            this.LblPlayerRank.AutoSize = true;
            this.LblPlayerRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerRank.Location = new System.Drawing.Point(13, 102);
            this.LblPlayerRank.Name = "LblPlayerRank";
            this.LblPlayerRank.Size = new System.Drawing.Size(243, 38);
            this.LblPlayerRank.TabIndex = 6;
            this.LblPlayerRank.Text = "Player rankings";
            // 
            // LblMatchRank
            // 
            this.LblMatchRank.AutoSize = true;
            this.LblMatchRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatchRank.Location = new System.Drawing.Point(788, 105);
            this.LblMatchRank.Name = "LblMatchRank";
            this.LblMatchRank.Size = new System.Drawing.Size(239, 38);
            this.LblMatchRank.TabIndex = 7;
            this.LblMatchRank.Text = "Match rankings";
            // 
            // LbNOVPM
            // 
            this.LbNOVPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNOVPM.FormattingEnabled = true;
            this.LbNOVPM.ItemHeight = 25;
            this.LbNOVPM.Location = new System.Drawing.Point(795, 198);
            this.LbNOVPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbNOVPM.Name = "LbNOVPM";
            this.LbNOVPM.Size = new System.Drawing.Size(745, 354);
            this.LbNOVPM.TabIndex = 9;
            // 
            // LblNOVPM
            // 
            this.LblNOVPM.AutoSize = true;
            this.LblNOVPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOVPM.Location = new System.Drawing.Point(791, 165);
            this.LblNOVPM.Name = "LblNOVPM";
            this.LblNOVPM.Size = new System.Drawing.Size(372, 25);
            this.LblNOVPM.TabIndex = 10;
            this.LblNOVPM.Text = "Sorted by number of visitors (Attendance)";
            // 
            // TcPlayerRankings
            // 
            this.TcPlayerRankings.Controls.Add(this.TpGoals);
            this.TcPlayerRankings.Controls.Add(this.TpYellowCards);
            this.TcPlayerRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcPlayerRankings.Location = new System.Drawing.Point(21, 165);
            this.TcPlayerRankings.Margin = new System.Windows.Forms.Padding(4);
            this.TcPlayerRankings.Name = "TcPlayerRankings";
            this.TcPlayerRankings.SelectedIndex = 0;
            this.TcPlayerRankings.Size = new System.Drawing.Size(743, 559);
            this.TcPlayerRankings.TabIndex = 11;
            // 
            // TpGoals
            // 
            this.TpGoals.Controls.Add(this.LbGoals);
            this.TpGoals.Location = new System.Drawing.Point(4, 34);
            this.TpGoals.Margin = new System.Windows.Forms.Padding(4);
            this.TpGoals.Name = "TpGoals";
            this.TpGoals.Padding = new System.Windows.Forms.Padding(4);
            this.TpGoals.Size = new System.Drawing.Size(735, 521);
            this.TpGoals.TabIndex = 0;
            this.TpGoals.Text = "Sorted by goals";
            this.TpGoals.UseVisualStyleBackColor = true;
            // 
            // LbGoals
            // 
            this.LbGoals.FormattingEnabled = true;
            this.LbGoals.ItemHeight = 25;
            this.LbGoals.Location = new System.Drawing.Point(8, 7);
            this.LbGoals.Margin = new System.Windows.Forms.Padding(4);
            this.LbGoals.Name = "LbGoals";
            this.LbGoals.Size = new System.Drawing.Size(715, 479);
            this.LbGoals.TabIndex = 0;
            // 
            // TpYellowCards
            // 
            this.TpYellowCards.Controls.Add(this.LbYellowCards);
            this.TpYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpYellowCards.Location = new System.Drawing.Point(4, 34);
            this.TpYellowCards.Margin = new System.Windows.Forms.Padding(4);
            this.TpYellowCards.Name = "TpYellowCards";
            this.TpYellowCards.Padding = new System.Windows.Forms.Padding(4);
            this.TpYellowCards.Size = new System.Drawing.Size(735, 521);
            this.TpYellowCards.TabIndex = 1;
            this.TpYellowCards.Text = "Sorted by yellow cards";
            this.TpYellowCards.UseVisualStyleBackColor = true;
            // 
            // LbYellowCards
            // 
            this.LbYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbYellowCards.FormattingEnabled = true;
            this.LbYellowCards.ItemHeight = 25;
            this.LbYellowCards.Location = new System.Drawing.Point(8, 7);
            this.LbYellowCards.Margin = new System.Windows.Forms.Padding(4);
            this.LbYellowCards.Name = "LbYellowCards";
            this.LbYellowCards.Size = new System.Drawing.Size(715, 479);
            this.LbYellowCards.TabIndex = 0;
            // 
            // BtnPrintNumberOfVisitors
            // 
            this.BtnPrintNumberOfVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintNumberOfVisitors.Location = new System.Drawing.Point(1291, 579);
            this.BtnPrintNumberOfVisitors.Name = "BtnPrintNumberOfVisitors";
            this.BtnPrintNumberOfVisitors.Size = new System.Drawing.Size(234, 106);
            this.BtnPrintNumberOfVisitors.TabIndex = 12;
            this.BtnPrintNumberOfVisitors.Text = "Print number of visitors";
            this.BtnPrintNumberOfVisitors.UseVisualStyleBackColor = true;
            this.BtnPrintNumberOfVisitors.Click += new System.EventHandler(this.BtnPrintNumberOfVisitors_Click);
            // 
            // printDocumentAttendance
            // 
            this.printDocumentAttendance.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentNumberOfVisitors_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // BtnPrintGoals
            // 
            this.BtnPrintGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintGoals.Location = new System.Drawing.Point(1051, 579);
            this.BtnPrintGoals.Name = "BtnPrintGoals";
            this.BtnPrintGoals.Size = new System.Drawing.Size(234, 106);
            this.BtnPrintGoals.TabIndex = 13;
            this.BtnPrintGoals.Text = "Print goals";
            this.BtnPrintGoals.UseVisualStyleBackColor = true;
            this.BtnPrintGoals.Click += new System.EventHandler(this.BtnPrintGoals_Click);
            // 
            // printDocumentGoals
            // 
            this.printDocumentGoals.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentGoals_PrintPage);
            // 
            // printDocumentYellowCards
            // 
            this.printDocumentYellowCards.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentYellowCards_PrintPage);
            // 
            // BtnPrintYellowCards
            // 
            this.BtnPrintYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintYellowCards.Location = new System.Drawing.Point(811, 579);
            this.BtnPrintYellowCards.Name = "BtnPrintYellowCards";
            this.BtnPrintYellowCards.Size = new System.Drawing.Size(234, 106);
            this.BtnPrintYellowCards.TabIndex = 14;
            this.BtnPrintYellowCards.Text = "Print yellow cards";
            this.BtnPrintYellowCards.UseVisualStyleBackColor = true;
            this.BtnPrintYellowCards.Click += new System.EventHandler(this.BtnPrintYellowCards_Click);
            // 
            // RankingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 903);
            this.ControlBox = false;
            this.Controls.Add(this.BtnPrintYellowCards);
            this.Controls.Add(this.BtnPrintGoals);
            this.Controls.Add(this.BtnPrintNumberOfVisitors);
            this.Controls.Add(this.TcPlayerRankings);
            this.Controls.Add(this.LblNOVPM);
            this.Controls.Add(this.LbNOVPM);
            this.Controls.Add(this.LblMatchRank);
            this.Controls.Add(this.LblPlayerRank);
            this.Controls.Add(this.LblRankings);
            this.Controls.Add(this.BtnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RankingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rankings Form";
            this.Load += new System.EventHandler(this.RankingsForm_Load);
            this.TcPlayerRankings.ResumeLayout(false);
            this.TpGoals.ResumeLayout(false);
            this.TpYellowCards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblRankings;
        private System.Windows.Forms.Label LblPlayerRank;
        private System.Windows.Forms.Label LblMatchRank;
        private System.Windows.Forms.ListBox LbNOVPM;
        private System.Windows.Forms.Label LblNOVPM;
        private System.Windows.Forms.TabControl TcPlayerRankings;
        private System.Windows.Forms.TabPage TpGoals;
        private System.Windows.Forms.TabPage TpYellowCards;
        private System.Windows.Forms.ListBox LbGoals;
        private System.Windows.Forms.ListBox LbYellowCards;
        private System.Windows.Forms.Button BtnPrintNumberOfVisitors;
        private System.Drawing.Printing.PrintDocument printDocumentAttendance;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button BtnPrintGoals;
        private System.Drawing.Printing.PrintDocument printDocumentGoals;
        private System.Drawing.Printing.PrintDocument printDocumentYellowCards;
        private System.Windows.Forms.Button BtnPrintYellowCards;
    }
}