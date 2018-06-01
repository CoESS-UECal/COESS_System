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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

        }

        int ID;
        public static bool isregistration = false;


        private void Registration_Load(object sender, EventArgs e)
        {
            isregistration = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;");
                ID = Convert.ToInt32(textBox1.Text);
                MainMenu.Insert("insert into "+Event_List.event_name+" (ID_No, FN, LN, SN) select ID_No, FN, LN, SN from coess.member_list where ID_No = "+ID+";");
                textBox1.Text = null;
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
