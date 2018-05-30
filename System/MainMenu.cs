using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class MainMenu : Form
    {//"server=localhost;uid=root;pwd=;database=coess;"
        //"server=localhost;uid=root;pwd=;database=coess_events;"
        //Database connection variables
        public static MySqlConnection conn;
        public static string myConnectionString;

        public MainMenu()
        {
            InitializeComponent();

        }
        
        public static void Initialize(string connstr)
        {
            myConnectionString =connstr;
            conn = new MySqlConnection(myConnectionString);
        }

        //Opening connection to database
        public static bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //closing connection to database
        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert into database
        public static void Insert(string q)
        {
            string query = q;
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted!", "Insert Successful!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }






        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }

        private void imageLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Always put all Images in C:\\COESS\\Images\\.\nThank You.","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This COESS Master Database System is created by COESS 2018-2019." + Environment.NewLine + "\n©Christer Jude A. Mananquil, Vice President - Internal (2018-2019)\n©Charles Edward D. Bernardo, Lead Programmer(2018-2019)\nAll Rights Reserved.\nNo part of this system can be reproduced nor modified without consent from the developer.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form members = new Members();
            members.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("You will be Logged Out. Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Form login = new Login();
                login.Show();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form events = new Events();
            events.Show();
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
