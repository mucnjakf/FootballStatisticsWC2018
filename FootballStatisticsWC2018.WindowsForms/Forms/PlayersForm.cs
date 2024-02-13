using DataAccessLayer.DAO;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        // Form Events

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            ShowAllPlayersPanels();
        }

        private void FlpFavPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FlpFavPlayers_DragDrop(object sender, DragEventArgs e)
        {
            if(FlpFavPlayers.Controls.Count < 3)
            {
                Panel playerPanel = (Panel)e.Data.GetData(typeof(Panel));
                playerPanel.Location = new Point(0, 0);

                FlpFavPlayers.Controls.Add(playerPanel);
            }
            else
            {
                MessageBox.Show("You can choose only 3 favorite players!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void FlpAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FlpAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            Panel playerPanel = (Panel)e.Data.GetData(typeof(Panel));
            playerPanel.Location = new Point(0, 0);

            FlpAllPlayers.Controls.Add(playerPanel);
        }

        private void PlayerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop(sender as Panel, DragDropEffects.Move);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();

            var mainForm = new MainForm();

            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }

        // Methods
 
        private void ShowAllPlayersPanels()
        {
            FlpAllPlayers.Controls.Clear();

            IEnumerable<Player> players = DataRepository.GetPlayers();

            foreach (Player player in players)
            {
                Panel playerPanel = new Panel()
                {
                    Size = new Size(290, 130),
                    BorderStyle = BorderStyle.FixedSingle
                };

                playerPanel.MouseDown += PlayerPanel_MouseDown;  

                int x = 20, y = 20;

                Point nameLocation = new Point(x, y);
                Point captainLocation = new Point(x, nameLocation.Y + y);
                Point shirtNumberLocation = new Point(x, captainLocation.Y + y);
                Point positionLocation = new Point(x, shirtNumberLocation.Y + y);

                playerPanel.Controls.Add(GetLabel(player.Name, nameLocation));
                playerPanel.Controls.Add(GetLabel(player.Captain ? "Captain" : "Not captain", captainLocation));
                playerPanel.Controls.Add(GetLabel(player.Shirt_number.ToString(), shirtNumberLocation));
                playerPanel.Controls.Add(GetLabel(player.Position, positionLocation));

                FlpAllPlayers.Controls.Add(playerPanel);
            }
        }
        
        private Control GetLabel(string txt, Point location)
        {
            Label playerLbl = new Label()
            {
                Text = txt,
                Location = location,
                Width = 320,
                Height = 20,
                Font = new Font("Microsoft Sans Serif", 12)         
            };

            playerLbl.Enabled = false;

            return playerLbl;
        }
    }
}
