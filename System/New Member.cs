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
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to go back?\n\nAll information will be discarded.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form members = new Members();
                members.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//std_no,fn,mi,ln,email,home,contact,bday,age,yr,comitte,guar_name,gard_no
            MainMenu.Insert("insert into member_list(SN,FN,MI,LN,Email,Address,Contact_No,BDay,Age,Year_Level,Comm,Guard_Name,Guard_Contact) values('" +SN.Text + "','" + FN.Text + "','" + MI.Text + "','" + LN.Text + "','" + EMail.Text + "','" + Address.Text + "','" + Contact.Text + "','" + Convert.ToString(Bday.Value.ToShortDateString()) + "'," + Age.Value + ",'" + Year.SelectedItem + "','" + Comm.SelectedItem + "','" + GuardName.Text + "','" + GuardContact.Text + "');");
            FN.Text = null;
            MI.Text = null;
            LN.Text = null;
            SN.Text = null;
            EMail.Text = null;
            Address.Text = null;
            Contact.Text = null;
            Bday.Value = DateTime.Today;
            Age.Value = 0;
            Year.Text=null;
            Comm.Text=null;
            GuardName.Text = null;
            GuardContact.Text = null;
            if (DialogResult.Yes == MessageBox.Show("Would you like to go back?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form members = new Members();
                members.Show();
                Close();
            }

        }
    }
}

