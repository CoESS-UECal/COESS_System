using System.Drawing;
using System.Windows.Forms;

namespace System
{
    public partial class New_Member : Form
    {
        string membership_type;
        string error;

        public New_Member()
        {
            InitializeComponent();
            if (MainMenu.isMaster == true)
            {
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
            }
            else
            {
                MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
            }
            FN.Text = "First Name";
            FN.ForeColor = SystemColors.GrayText;
            MI.Text = "MI";
            MI.ForeColor = SystemColors.GrayText;
            LN.Text = "Last Name";
            LN.ForeColor = SystemColors.GrayText;
            EMail.Text = "someone@example.com";
            EMail.ForeColor = SystemColors.GrayText;
            Address.Text = "Address";
            Address.ForeColor = SystemColors.GrayText;
            GuardName.Text = "Guardian Name";
            GuardName.ForeColor = SystemColors.GrayText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainmenu = new MainMenu();
            mainmenu.Show();
            Close();
        }

        public string requirements()
        {
            //SN,FN,MI,LN,Email,Address,Contact_No,BDay,Age,Year_Level,Comm,Guard_Name,Guard_Contact,ID_Address
            //shorten code in insertion
            string complete = null;
            complete += EnCryptDecrypt.CryptorEngine.Encrypt(SN.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(FN.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(MI.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(LN.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(EMail.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Address.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Contact.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Convert.ToString(Bday.Value.ToShortDateString()), true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Age.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Year.SelectedItem.ToString(), true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Comm.SelectedItem.ToString(), true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(GuardName.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(GuardContact.Text, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(membership_type, true);
            complete = complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(@"C:\\COESS\\Images\\Member\\default.png", true);
            return complete;
        }

        private void button1_Click(object sender, EventArgs e)
        {//std_no,fn,mi,ln,email,home,contact,bday,age,yr,comitte,guar_name,gard_no,dpa
            bool sn_flag = SN.MaskCompleted != false;
            bool fn_flag = FN.Text != "";
            bool mi_flag = MI.Text != "";
            bool ln_flag = LN.Text != "";
            bool email_flag = EMail.Text != "";
            bool address_flag = Address.Text != "";
            bool contact_flag = Contact.MaskCompleted != false;
            bool bday_flag = Bday.Value.ToShortDateString() != DateTime.Now.ToShortDateString();
            bool age_flag = Int32.Parse(Age.Text) > 0;
            bool year_flag = Year.Text != "";
            bool com_flag = Comm.Text != "";
            bool Guardname_flag = GuardName.Text != "";
            bool Guardcontact_flag = GuardContact.MaskCompleted != false;
            bool DPA_flag = checkBox1.Checked != false;
            bool membership = radioButton1.Checked != false || radioButton2.Checked != false;

            error = null;
            if (!sn_flag || !fn_flag || !mi_flag || !ln_flag || !email_flag || !address_flag || !contact_flag || !bday_flag || !year_flag || !com_flag || !Guardname_flag || !Guardcontact_flag || !DPA_flag || !age_flag || !membership)
            {

                if (!fn_flag)
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
                if (!email_flag)
                {
                    error += "Email must not be Empty \n";
                }
                if (!address_flag)
                {
                    error += "Address must not be Empty \n";
                }
                if (!contact_flag)
                {
                    error += "Contact Number must not be Empty\n";
                }
                if (!bday_flag)
                {
                    if (Bday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        error += "Date of Birth must not the same as Date Today\n";
                    }
                    else
                    {
                        error += "Date of Birth does not match your Age\n";
                    }
                }
                if (!age_flag)
                {
                    error += "Age must not be 0 or a Negative Value";
                }
                if (!year_flag)
                {
                    error += "Year Level must not be Empty\n";
                }
                if (!com_flag)
                {
                    error += "Commitee Affiliation must not be Empty\n";
                }
                if (!Guardname_flag)
                {
                    error += "Guardian Name must not be Empty\n";
                }
                if (!Guardcontact_flag)
                {
                    error += "Guardian Contact Number must not be Empty\n";
                }
                if (!DPA_flag)
                {
                    error += "Data Privacy Act of 2012 not checked";
                }
                if (!membership)
                {
                    error += "Select Membership Type";
                }
                MessageBox.Show(error, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Error Message Box for Invalid Data
            }
            else
            {
                MainMenu.Insert("insert into member_list(SN,FN,MI,LN,Email,Address,Contact_No,BDay,Age,Year_Level,Comm,Guard_Name,Guard_Contact,Membership,ID_Address) values('" + requirements() + "');");
                FN.Text = null;
                MI.Text = null;
                LN.Text = null;
                SN.Text = null;
                EMail.Text = null;
                Address.Text = null;
                Contact.Text = null;
                Bday.Value = DateTime.Today;
                Age.Text = null;
                Year.Text = null;
                Comm.Text = null;
                GuardName.Text = null;
                GuardContact.Text = null;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                if (DialogResult.Yes == MessageBox.Show("New Member Registered!\n\nWould you like to go back?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Form mainmenu = new MainMenu();
                    mainmenu.Show();
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
            if (DialogResult.OK == MessageBox.Show(
                "I am fully aware that CoESS or its designated representative is duty bound and obligated under the Data Privacy Act of 2012 to protect all my personal and sensitive information that it collects, processes, and retains upon my enrolment and during my stay in the University.\n\n" +
                "Student personal information includes any information about my identity, academics, medical conditions, or any documents containing my identity.This includes but not limited to my name, address, names of my parents or guardians, date of birth, grades, attendance, disciplinary records, and other information necessary for basic administration and instruction.\n\n" +
                "I understand that my personal information cannot be disclosed without my consent.\n\nI understand that the information that was collected and processed relates to my enrolment and to be used by CoESS to pursue its legitimate interests as an educational institution.\n\nLikewise, I am fully aware that CoESS may share such information to affiliated or partner organizations" +
                "as part of its contractual obligations, or with government agencies pursuant to law or legal processes.\n\nIn this regard, I hereby allow CoESS to collect, process, use and share my personal data in the pursuit of its legitimate interests as an educational institution.\n\n" +
                "In addition, I am likewise giving my consent / permission in favor of my parents / guardian / representative or whoever is responsible in providing care for me to access, verify, examine and or inspect my academic and scholastic records, school fees / accounts in the University, the result of my physical medical examination(PME) and all matters that relate to my status as a student of the University.\n\n" +
                "Finally, should I commit any misconduct or should there be a complaint filed against me, before the Student Affairs Office(SAO) or Student Disciplinary Board(SDB) by reason of violation of the provisions of the Student Manual or any laws or ordinances, I hereby authorize and give my full consent in favor of the University to inform my parents, guardian, representative or whoever person is in charge of providing care or custody for me.\n\n" +
                "Upon clicking OK, I hereby give my consent for the processing, release, and retention of personal information.", "Data Privacy Act of 2012", MessageBoxButtons.OKCancel))
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void Bday_ValueChanged(object sender, EventArgs e)
        {
            int age;
            if ((DateTime.Now.Month - Bday.Value.Month >= 0) && (DateTime.Now.DayOfYear - Bday.Value.DayOfYear >= 0))
            {
                age = DateTime.Now.Year - Bday.Value.Year;
            }
            else
            {
                age = DateTime.Now.Year - (Bday.Value.Year + 1);
            }
            Age.Text = age.ToString();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            membership_type = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            membership_type = radioButton2.Text;
        }

        private void FN_Leave(object sender, EventArgs e)
        {
            if (FN.Text.Length == 0)
            {
                FN.Text = "First Name";
                FN.ForeColor = SystemColors.GrayText;
            }
        }

        private void FN_Enter(object sender, EventArgs e)
        {
            if (FN.Text == "First Name")
            {
                FN.Text = "";
                FN.ForeColor = Color.White;
            }
        }

        private void MI_Enter(object sender, EventArgs e)
        {
            if (MI.Text == "MI")
            {
                MI.Text = "";
                MI.ForeColor = Color.White;
            }
        }

        private void MI_Leave(object sender, EventArgs e)
        {
            if (MI.Text.Length == 0)
            {
                MI.Text = "MI";
                MI.ForeColor = SystemColors.GrayText;
            }
        }

        private void LN_Enter(object sender, EventArgs e)
        {
            if (LN.Text == "Last Name")
            {
                LN.Text = "";
                LN.ForeColor = Color.White;
            }
        }

        private void LN_Leave(object sender, EventArgs e)
        {
            if (LN.Text.Length == 0)
            {
                LN.Text = "Last Name";
                LN.ForeColor = SystemColors.GrayText;
            }
        }

        private void EMail_Enter(object sender, EventArgs e)
        {
            if (EMail.Text == "someone@example.com")
            {
                EMail.Text = "";
                EMail.ForeColor = Color.White;
            }
        }

        private void EMail_Leave(object sender, EventArgs e)
        {
            if (EMail.Text.Length == 0)
            {
                EMail.Text = "someone@example.com";
                EMail.ForeColor = SystemColors.GrayText;
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (Address.Text == "Address")
            {
                Address.Text = "";
                Address.ForeColor = Color.White;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (Address.Text.Length == 0)
            {
                Address.Text = "Address";
                Address.ForeColor = SystemColors.GrayText;
            }
        }

        private void GuardName_Enter(object sender, EventArgs e)
        {
            if (GuardName.Text == "Guardian Name")
            {
                GuardName.Text = "";
                GuardName.ForeColor = Color.White;
            }
        }

        private void GuardName_Leave(object sender, EventArgs e)
        {
            if (GuardName.Text.Length == 0)
            {
                GuardName.Text = "Guardian Name";
                GuardName.ForeColor = SystemColors.GrayText;
            }
        }

    }
}

