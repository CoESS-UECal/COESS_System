using System.Drawing;
using System.Windows.Forms;

namespace System
{
    public partial class Access : Form
    {
        int tries = 3;
        public static bool access;

        //This form is for accessing Officer/Faculty-related options such as Member Lists or exporting member data.
        public Access()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if ((UserBox.Text == "Officer" || UserBox.Text == "Professor") && PasswordBox.Text == Properties.Settings.Default.Alt_Pass)
            {
                access = true;
                Close();
            }
            else if (tries >= 1)
            {
                tries--;
                MessageBox.Show("Invalid Username/Password\nNumber of Tries Left :" + tries.ToString(), "Username/Password Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (tries == 0)
                {
                    MessageBox.Show("Application Closing\nUsername/Password Error", "Username/Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void Access_Load(object sender, EventArgs e)
        {
            access = false;
            Loginbutton.Enabled = false;
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text.Length == 0)
            {
                UserBox.Text = "Username";
                UserBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            if (UserBox.Text == "Username")
            {
                UserBox.Text = "";
                UserBox.ForeColor = Color.White;
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

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.White;
            }
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to go back?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Close();
            }
        }
    }
}
