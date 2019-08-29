using System;
using System.Diagnostics;
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
    public partial class Login : Form
    {
        string password = "CPE1";
        int tries = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if ((UserBox.Text == "Officer" || UserBox.Text == "Professor") && PasswordBox.Text == password)
            {
                Form form1 = new MainMenu();
                form1.Show();
                this.Hide();
            }
            
                else if (tries >= 1)
                {
                    tries--;
                    MessageBox.Show("Invalid Username/Password\nNumber of Tries Left :" + tries.ToString());
                    if (tries == 0)
                    {
                        MessageBox.Show("Application Closing\nUsername/Password Error");
                        Application.Exit();
                    }
                }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Loginbutton.Enabled = false;
            //MessageBox.Show(EnCryptDecrypt.CryptorEngine.Encrypt("20151163018", true));
            //Clipboard.SetText(EnCryptDecrypt.CryptorEngine.Encrypt("20151163018", true));
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
            if (DialogResult.Yes==MessageBox.Show("Do you want to quit?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information))
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
