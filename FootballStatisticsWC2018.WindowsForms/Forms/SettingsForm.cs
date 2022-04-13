using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to change language?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();

                var mainForm = new MainForm();

                mainForm.FormClosed += (s, args) => Close();
                mainForm.Show();
            }
            else
            {
                Hide();

                var mainForm = new MainForm();

                mainForm.FormClosed += (s, args) => Close();
                mainForm.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
