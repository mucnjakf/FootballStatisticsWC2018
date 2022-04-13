using System;
using System.Windows.Forms;
using WindowsForms.Forms;

namespace WindowsForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // Form Events

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (RbEng.Checked == false && RbHrv.Checked == false)
            {
                MessageBox.Show("Select your language!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
