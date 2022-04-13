using DataAccessLayer.DAO;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class RankingsForm : Form
    {
        public RankingsForm()
        {
            InitializeComponent();
        }

        // Form Events

        private void RankingsForm_Load(object sender, EventArgs e)
        {
            ShowMatchRankingsLb();
            ShowPlayerRankingsTc();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();

            var mainForm = new MainForm();

            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }

        // Methods

        private void ShowMatchRankingsLb()
        {
            LbNOVPM.Items.Clear();

            List<Match> sortedMatches = DataRepository.GetMatchesForRankings().OrderByDescending(m => m.Attendance).ToList();

            foreach (var match in sortedMatches)
            {
                LbNOVPM.Items.Add(match.MatchesForRankingsToString());
            }   
        }

        private void ShowPlayerRankingsTc()
        {
            LbGoals.Items.Clear();

            List<TeamEvent> teamEvents = DataRepository.GetTeamEventsForRankings();

            foreach (var te in teamEvents)
            {
                if (te.Type_of_event.StartsWith("goal"))
                {
                    LbGoals.Items.Add(te);
                }
                else if (te.Type_of_event == "yellow-card")
                {
                    LbYellowCards.Items.Add(te);
                }
            }
        }

        private void printDocumentNumberOfVisitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left + 20;
            float y = e.MarginBounds.Top - 50;

            Bitmap bmp = new Bitmap(Width, Height);

            printDocumentAttendance.DefaultPageSettings.Landscape = true;
            LbNOVPM.DrawToBitmap(bmp, new Rectangle(0, 0, LbNOVPM.Width, LbNOVPM.Height));
            e.Graphics.DrawImage(bmp, x, y);

            bmp.Dispose();
        }

        private void BtnPrintNumberOfVisitors_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocumentAttendance;
            printPreviewDialog.ShowDialog();
        }

        private void BtnPrintGoals_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocumentGoals;
            printPreviewDialog.ShowDialog();
        }

        private void printDocumentGoals_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left + 20;
            float y = e.MarginBounds.Top - 50;

            Bitmap bmp = new Bitmap(Width, Height);

            printDocumentGoals.DefaultPageSettings.Landscape = true;
            LbGoals.DrawToBitmap(bmp, new Rectangle(0, 0, LbGoals.Width, LbGoals.Height));
            e.Graphics.DrawImage(bmp, x, y);

            bmp.Dispose();
        }

        private void printDocumentYellowCards_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left + 20;
            float y = e.MarginBounds.Top - 50;

            Bitmap bmp = new Bitmap(Width, Height);

            printDocumentYellowCards.DefaultPageSettings.Landscape = true;
            LbYellowCards.DrawToBitmap(bmp, new Rectangle(0, 0, LbYellowCards.Width, LbYellowCards.Height));
            e.Graphics.DrawImage(bmp, x, y);

            bmp.Dispose();
        }

        private void BtnPrintYellowCards_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocumentYellowCards;
            printPreviewDialog.ShowDialog();
        }
    }
}
