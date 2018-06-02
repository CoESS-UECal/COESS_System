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
    public partial class Registration_NoID : Form
    {
        public Event_List eventlist { get; set; }

        public Registration_NoID(Event_List _form1)
        {
            eventlist = _form1;
            InitializeComponent();
        }

        private void Registration_NoID_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;");
            MainMenu.Insert("insert into " + Event_List.event_name + " (FN, LN, SN) values ('" +textBox1.Text+ "','"+textBox2.Text+"','"+maskedTextBox1.Text+"');");
            textBox1.Text = null;
            textBox2.Text = null;
            maskedTextBox1.Text = null;
            eventlist.LA(Event_List.event_name);
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
        }

        private void Registration_NoID_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
