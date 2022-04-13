using DataAccessLayer.DAO;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetTeamsInComboBox();
        }

        private void BtnPlayers_Click(object sender, EventArgs e)
        {
            if (CbFavTeam.SelectedItem == null)
            {
                MessageBox.Show("Choose your favorite team!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GetFifaCodeFromTeam();

                Hide();

                var playersForm = new PlayersForm();

                playersForm.FormClosed += (s, args) => Close();
                playersForm.Show();
            }
        }

        private void BtnRankings_Click(object sender, EventArgs e)
        {
            if (CbFavTeam.SelectedItem == null)
            {
                MessageBox.Show("Choose your favorite team!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GetFifaCodeFromTeam();

                Hide();

                var rankingsForm = new RankingsForm();

                rankingsForm.FormClosed += (s, args) => Close();
                rankingsForm.Show();
            }

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Hide();

            var settingsForm = new SettingsForm();

            settingsForm.FormClosed += (s, args) => Close();
            settingsForm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void GetTeamsInComboBox()
        {
            foreach (var team in DataRepository.GetTeams_NamesFifaCode())
            {
                CbFavTeam.Items.Add((object)team.Value + " (" + team.Key + ")");
            }


            const string favTeamFile = @"E:\Dev Projects\UC Algebra\Semester IV - OOP .NET\DotNetProject\WindowsForms\saves/favTeamSave.txt";

            if (File.Exists(favTeamFile) && File.ReadAllText(favTeamFile) != "")
            {
                string teamName = File.ReadAllText(favTeamFile);

                foreach (var team in DataRepository.GetTeams_NamesFifaCode())
                {
                    string teamCode = team.Value + " (" + team.Key + ")";

                    if (teamCode == teamName)
                    {
                        CbFavTeam.SelectedItem = teamName;
                    }
                }
            }
        }

        public void GetFifaCodeFromTeam()
        {
            if (CbFavTeam.SelectedItem != null)
            {
                string selectedItem = CbFavTeam.SelectedItem.ToString();
                string fCode = selectedItem.Substring(selectedItem.IndexOf('(') + 1, 3);

                DataRepository.fifaCode = fCode;
            }
        }

        private void BtnSaveFavTeam_Click(object sender, EventArgs e)
        {
            if (CbFavTeam.SelectedItem == null)
            {
                MessageBox.Show("Choose your favorite team to save!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string favTeam = CbFavTeam.SelectedItem.ToString();

                DataRepository.SaveFavTeam(favTeam);

                MessageBox.Show("Favorite team has been saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}