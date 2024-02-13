using DataAccessLayer.DAO;
using DataAccessLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            GetFavTeamsInCb();
        }


        private void CbFavTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LblFavTeamGoals.Content = string.Empty;
            LblOppTeamGoals.Content = string.Empty;
            GetOppTeamsInCb();
        }
        private void BtnShowResult_Click(object sender, RoutedEventArgs e)
        {
            if (CbFavTeam.SelectedItem == null || CbOppTeam.SelectedItem == null)
            {
                MessageBox.Show("Select favorite and opposing team!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                ShowVersusResult();

                Image fieldImage = Field;
                field.Children.Clear();
                field.Children.Add(fieldImage);

                LoadFavPlayersOnField();
                LoadOppPlayersOnField();
            }

        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            Close();
        }

        private void GetFavTeamsInCb()
        {
            List<Team> teams = DataRepository.GetTeams();

            foreach (var team in teams)
            {
                string teamfifacode = team.Country + " (" + team.Fifa_code + ")";

                CbFavTeam.Items.Add(teamfifacode);
            }
        }


        private void GetOppTeamsInCb()
        {
            CbOppTeam.Items.Clear();
            CbOppTeam.Text = "SELECT OPPOSING TEAM";

            string selectedItem = CbFavTeam.SelectedItem.ToString();
            string teamName = selectedItem.Substring(0, selectedItem.IndexOf('(') - 1);
            string fifaCode = selectedItem.Substring(selectedItem.IndexOf('(') + 1, 3);

            List<Match> matches = DataRepository.GetMatches(fifaCode);
            List<Team> teams = DataRepository.GetTeams();

            foreach (var match in matches)
            {
                foreach (var team in teams)
                {
                    if (match.Away_team_country == team.Country || match.Home_team_country == team.Country)
                    {
                        if (team.Country != teamName)
                        {
                            string teamfifacode = team.Country + " (" + team.Fifa_code + ")";

                            CbOppTeam.Items.Add(teamfifacode);
                        }
                    }
                }
            }
        }


        private void ShowVersusResult()
        {
            var favTeam = CbFavTeam.SelectedItem.ToString();
            string favTeamName = favTeam.Substring(0, favTeam.IndexOf('(') - 1);
            string favFifaCode = favTeam.Substring(favTeam.IndexOf('(') + 1, 3);

            var oppTeam = CbOppTeam.SelectedItem.ToString();
            string oppTeamName = oppTeam.Substring(0, oppTeam.IndexOf('(') - 1);
            string oppFifaCode = favTeam.Substring(favTeam.IndexOf('(') + 1, 3);

            int favTeamGoals = DataRepository.GetTeamGoals(favTeamName, oppTeamName, favFifaCode);
            int oppTeamGoals = DataRepository.GetTeamGoals(oppTeamName, favTeamName, oppFifaCode);

            LblFavTeamGoals.Content = favTeamGoals;
            LblOppTeamGoals.Content = oppTeamGoals;
        }


        private void LoadFavPlayersOnField()
        {
            var favTeam = CbFavTeam.SelectedItem.ToString();
            string favFifaCode = favTeam.Substring(favTeam.IndexOf('(') + 1, 3);

            var oppTeam = CbOppTeam.SelectedItem.ToString();
            string oppFifaCode = oppTeam.Substring(oppTeam.IndexOf('(') + 1, 3);

            List<Player> favTeamStartingEleven = DataRepository.GetStartingEleven(favFifaCode, oppFifaCode);

            int defRow = 1;
            int midRow = 1;
            int attRow = 1;
            
            foreach (Player player in favTeamStartingEleven)
            {  
                if (player.Position == "Goalie")
                {                    
                    PlayerControl playerControl = new PlayerControl(player);
                    playerControl.HorizontalAlignment = HorizontalAlignment.Left;
                    Grid.SetRow(playerControl, 4);
                    Grid.SetColumn(playerControl, 0);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, defRow);
                    Grid.SetColumn(playerControl, 2);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    defRow += 2;
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, midRow);
                    Grid.SetColumn(playerControl, 4);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    midRow += 2;
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, attRow);
                    Grid.SetColumn(playerControl, 6);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    attRow += 2;
                }
            }
        }
        
        private void LoadOppPlayersOnField()
        {
            var favTeam = CbFavTeam.SelectedItem.ToString();
            string favFifaCode = favTeam.Substring(favTeam.IndexOf('(') + 1, 3);

            var oppTeam = CbOppTeam.SelectedItem.ToString();
            string oppFifaCode = oppTeam.Substring(oppTeam.IndexOf('(') + 1, 3);

            List<Player> oppTeamStartingEleven = DataRepository.GetStartingEleven(oppFifaCode, favFifaCode);

            int defRow = 1;
            int midRow = 1;
            int attRow = 1;

            foreach (Player player in oppTeamStartingEleven)
            {
                if (player.Position == "Goalie")
                {
                    PlayerControl playerControl = new PlayerControl(player);
                    playerControl.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(playerControl, 4);
                    Grid.SetColumn(playerControl, 14);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, defRow);
                    Grid.SetColumn(playerControl, 12);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    defRow += 2;
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, midRow);
                    Grid.SetColumn(playerControl, 10);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    midRow += 2;
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new PlayerControl(player)
                    {
                        HorizontalAlignment = HorizontalAlignment.Left
                    };
                    Grid.SetRow(playerControl, attRow);
                    Grid.SetColumn(playerControl, 8);
                    Grid.SetColumnSpan(playerControl, 2);

                    field.Children.Add(playerControl);

                    attRow += 2;
                }
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) => System.Windows.Application.Current.Shutdown();

        private void BtnFavTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            if (CbFavTeam.SelectedItem == null)
            {
                MessageBox.Show("Select favorite team!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                Team team = GetTeamName("favTeam");

                var teamInfo = new TeamInfo(team);
                teamInfo.Show();
            }
        }
        
        private void BtnOppTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            if (CbOppTeam.SelectedItem == null)
            {
                MessageBox.Show("Select opposing team!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                Team team = GetTeamName("oppTeam");

                var teamInfo = new TeamInfo(team);
                teamInfo.Show();
            }
        }

        private Team GetTeamName(string selectedTeam)
        {
            if (selectedTeam == "favTeam")
            {
                var favTeam = CbFavTeam.SelectedItem.ToString();
                string favTeamName = favTeam.Substring(0, favTeam.IndexOf('(') - 1);

                List<Team> teams = DataRepository.GetTeams();

                foreach (var team in teams)
                {
                    if (favTeamName == team.Country)
                    {
                        return team;
                    }
                }
            }
            else if (selectedTeam == "oppTeam")
            {
                var oppTeam = CbOppTeam.SelectedItem.ToString();
                string oppTeamName = oppTeam.Substring(0, oppTeam.IndexOf('(') - 1);

                List<Team> teams = DataRepository.GetTeams();

                foreach (var team in teams)
                {
                    if (oppTeamName == team.Country)
                    {
                        return team;
                    }
                }
            }
            return null;
        }
    }
}