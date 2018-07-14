using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Access : Form
    {
        string password = "Access";
        int tries = 3;
        public Access()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if ((UserBox.Text == "Officer" || UserBox.Text == "Professor") && PasswordBox.Text == password)
            {
                access = true;
                Close();
            }

            else if (tries >= 1)
            {
                tries--;
                MessageBox.Show("Invalid Username/Password\nNumber of Tries Left :" + tries.ToString());
                if (tries == 0)
                {
                    MessageBox.Show("Access Denied\nUsername/Password Error");
                    Close();
                }
            }

        }
        public static bool access;
        private void Access_Load(object sender, EventArgs e)
        {
            access = false;
            Loginbutton.Enabled = false;
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            if (UserBox.Text == "" || PasswordBox.Text == "")
            {
                Loginbutton.Enabled = false;
            }
            else
            {
                Loginbutton.Enabled = true;
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (UserBox.Text == "" || PasswordBox.Text == "")
            {
                Loginbutton.Enabled = false;
            }
            else
            {
                Loginbutton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to go back?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Close();
            }
        }
    }
}
