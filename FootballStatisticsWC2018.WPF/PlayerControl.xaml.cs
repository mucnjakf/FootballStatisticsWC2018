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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        private readonly Player player;
        public PlayerControl(Player player)
        {
            InitializeComponent();

            this.player = player;

            SetPlayerValues();
        }

        private void SetPlayerValues()
        {
            string format = player.Name;
            LblPlayerName.Text = format.Replace(" ", "\n");
            BtnPlayer.Content = player.Shirt_number;
        }

        private void BtnPlayer_Click(object sender, RoutedEventArgs e)
        {
            var playerInfo = new PlayerInfo(player);
            playerInfo.Show();
        }
    }
}
