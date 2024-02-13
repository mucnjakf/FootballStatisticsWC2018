using DataAccessLayer.Models;
using System;
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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        public TeamInfo(Team team)
        {
            InitializeComponent();

            SetTeamValues(team);
        }

        private void SetTeamValues(Team team)
        {
            LblName.Content = team.Country;
            LblWins.Content = team.Wins;
            LblDraws.Content = team.Draws;
            LblLosses.Content = team.Losses;
            LblGamesPlayed.Content = team.Games_played;
            LblPoints.Content = team.Points;
            LblGoalsFor.Content = team.Goals_for;
            LblGoalsAginst.Content = team.Goals_against;
            LblGoalsDiff.Content = team.Goal_differential;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e) => Close();
    }
}
