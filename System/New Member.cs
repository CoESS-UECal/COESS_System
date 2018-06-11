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
            //MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
            MainMenu.Initialize("server=localhost;uid=coess;pwd=uecalcpe2018;database=coess;");

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
        {//std_no,fn,mi,ln,email,home,contact,bday,age,yr,comitte,guar_name,gard_no,dpa
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
            bool DPA_flag = checkBox1.Checked != false;
            error = null;
            if (!sn_flag || !fn_flag || !mi_flag || !ln_flag || !email_flag || !address_flag || !contact_flag || !bday_flag || !age_flag || !year_flag || !com_flag || !Guardname_flag || !Guardcontact_flag||!DPA_flag)
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
                    error += "Last Name must not be Empty \n";
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
                        error += "Date of Birth does not match your Age\n";
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
                    error += "Guardian Contact Number must not be Empty\n";
                }
                if(!DPA_flag)
                {
                    error += "Data Privacy Act of 2012 not checked";
                }
                MessageBox.Show(error, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Error Message Box for Invalid Data
            }
            else
            {
       
            MainMenu.Insert("insert into member_list(SN,FN,MI,LN,Email,Address,Contact_No,BDay,Age,Year_Level,Comm,Guard_Name,Guard_Contact,ID_Address) values('" +SN.Text + "','" + FN.Text + "','" + MI.Text + "','" + LN.Text + "','" + EMail.Text + "','" + Address.Text + "','" + Contact.Text + "','" + Convert.ToString(Bday.Value.ToShortDateString()) + "'," + Age.Value + ",'" + Year.SelectedItem + "','" + Comm.SelectedItem + "','" + GuardName.Text + "','" + GuardContact.Text + "','"+@"C:\\COESS\\Images\\Member\\default.png"+"');");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show(
                @"I am fully aware that Computer Engineering Students' Society (CoESS) or its designated representative is duty bound and obligated under the Data Privacy Act of 2012 to protect all my personal and sensitive information that it collects, processes, and retains upon my enrolment and during my stay in the University.\j
Student personal information includes any information about my identity, academics, medical conditions, or any documents containing my identity.This includes but not limited to my name, address, names of my parents or guardians, date of birth, grades, attendance, disciplinary records, and other information necessary for basic administration and instruction.
I understand that my personal information cannot be disclosed without my consent.I understand that the information that was collected and processed relates to my enrolment and to be used by CoESS to pursue its legitimate interests as an educational institution.Likewise, I am fully aware that CoESS may share such information to affiliated or partner organizations as part of its contractual obligations, or with government agencies pursuant to law or legal processes.In this regard, I hereby allow CoESS to collect, process, use and share my personal data in the pursuit of its legitimate interests as an educational institution.
In addition, I am likewise giving my consent / permission in favor of my parents / guardian / representative or whoever is responsible in providing care for me to access, verify, examine and or inspect my academic and scholastic records, school fees / accounts in the University, the result of my physical medical examination(PME) and all matters that relate to my status as a student of the University.
     Finally, should I commit any misconduct or should there be a complaint filed against me, before the Student Affairs Office(SAO) or Student Disciplinary Board(SDB) by reason of violation of the provisions of the Student Manual or any laws or ordinances, I hereby authorize and give my full consent in favor of the University to inform my parents, guardian, representative or whoever person is in charge of providing care or custody for me.
  Upon clicking OK, I hereby give my consent for the processing, release, and retention of personal information."))
            {
                checkBox1.Checked = true;
            }
        }
    }
}

