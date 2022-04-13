using DataAccessLayer.DAO;
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
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        public PlayerInfo(Player player)
        {
            InitializeComponent();

            SetPlayerValues(player);
        }

        private void SetPlayerValues(Player player)
        {
            LblName.Content = player.Name;

            if (player.Captain)
            {
                LblCaptain.Content = "Yes";
            }
            else
            {
                LblCaptain.Content = "No";
            }

            LblShirtNum.Content = player.Shirt_number;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e) => Close();
        
    }
}
