using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace System
{
    public partial class Login : Form
    {
        
        int tries = 3;
        public Login()
        {
            InitializeComponent();
            UserBox.Text = "Username";
            UserBox.ForeColor = SystemColors.GrayText;
            PasswordBox.Text = "Password";
            PasswordBox.ForeColor = SystemColors.GrayText;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if ((UserBox.Text == "Officer" || UserBox.Text == "Professor") && PasswordBox.Text == Properties.Settings.Default.Password)
            {
                Process[] pname = Process.GetProcessesByName("mysqld");
                if (pname.Length == 0)
                {
                    Process.Start(@"C:\xampp\mysql\bin\mysqld.exe");
                }
                else
                {

                }
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

        private void UserBox_Enter(object sender, EventArgs e)
        {
            if (UserBox.Text == "Username")
            {
                UserBox.Text = "";
                UserBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text.Length == 0)
            {
                UserBox.Text = "Username";
                UserBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length == 0)
            {
                PasswordBox.Text = "Password";
                PasswordBox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
