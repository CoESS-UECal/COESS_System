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

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to go back?\n\nAll information will be discarded.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form members = new Members();
                members.Show();
                Close();
            }
        }
        string error;
        private void button1_Click(object sender, EventArgs e)
        {//std_no,fn,mi,ln,email,home,contact,bday,age,yr,comitte,guar_name,gard_no]
            bool sn_flag = SN.Text != "";
            bool fn_flag = FN.Text != "";
            bool mi_flag = MI.Text != "";
            bool ln_flag = LN.Text != "";
            bool email_flag = EMail.Text != "";
            bool address_flag = Address.Text != "";
            bool contact_flag = Contact.Text != "";
            bool bday_flag = Bday.Value.ToShortDateString() != DateTime.Now.ToShortDateString() && (Bday.Value.Year == DateTime.Now.Year - Age.Value || Bday.Value.Year == DateTime.Now.Year - (Age.Value + 1));
            bool age_flag = Age.Value != 0 && (Age.Value == DateTime.Now.Year - Bday.Value.Year || Age.Value == DateTime.Now.Year - (Bday.Value.Year + 1));
            bool year_flag = Year.Text != "";
            bool com_flag = Comm.Text != "";
            bool Guardname_flag = GuardName.Text != "";
            bool Guardcontact_flag =  GuardContact.Text != "";
            error = null;
            if (!sn_flag || !fn_flag || !mi_flag || !ln_flag || !email_flag || !address_flag || !contact_flag || !bday_flag || !age_flag || !year_flag || !com_flag || !Guardname_flag || !Guardcontact_flag)
            {
                
                if(!fn_flag)
                {
                    error += "First Name must not be Empty \n";
                }
                if (!mi_flag)
                {
                    error += "Middle Initial must not be Empty \n";
                }
                if (!ln_flag)
                {
                    error += "Last  Name must not be Empty \n";
                }
                if (!sn_flag)
                {
                    error += "Student Number must not be Empty \n";
                }
                if(!email_flag)
                {
                    error += "Email must not be Empty \n";
                }
                if(!address_flag)
                {
                    error += "Address must not be Empty \n";
                }
                if(!contact_flag)
                {
                    error += "Contact Number must not be Empty\n";
                }
                if(!bday_flag)
                {
                    if(Bday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        error += "Date of Birth must not the same as Date Today\n";
                    }
                    else
                    {
                        error += "Date of Birth does not match the Age\n";
                    }
                }
                if(!age_flag)
                {
                  if(Age.Value == 0)
                    {
                        error += "Age must not be equal to 0\n";
                    }
                  else
                    {
                        error += "Age does not match the Birthday\n";
                    }
                }
                if(!year_flag)
                {
                    error += "Year Level must not be Empty\n";
                }
                if(!com_flag)
                {
                    error += "Commitee Affiliation must not be Empty\n";
                }
                if(!Guardname_flag)
                {
                    error += "Guardian Name must not be Empty\n";
                }
                if(!Guardcontact_flag)
                {
                    error += "Guardian Contact Number must not be Empty";
                }
                MessageBox.Show(error, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Error Message Box for Invalid Data
            }
            else
            {
       
            //MainMenu.Insert("insert into member_list(SN,FN,MI,LN,Email,Address,Contact_No,BDay,Age,Year_Level,Comm,Guard_Name,Guard_Contact,ID_Address) values('" +SN.Text + "','" + FN.Text + "','" + MI.Text + "','" + LN.Text + "','" + EMail.Text + "','" + Address.Text + "','" + Contact.Text + "','" + Convert.ToString(Bday.Value.ToShortDateString()) + "'," + Age.Value + ",'" + Year.SelectedItem + "','" + Comm.SelectedItem + "','" + GuardName.Text + "','" + GuardContact.Text + "','"+@"C:\\COESS\\Images\\Member\\default.png"+"');");
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

        private void New_Member_Load(object sender, EventArgs e)
        {
            Bday.Value = DateTime.Now;
        }
    }
}

