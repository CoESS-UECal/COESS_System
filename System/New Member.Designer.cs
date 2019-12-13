namespace System
{
    partial class New_Member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Member));
            this.FN = new System.Windows.Forms.TextBox();
            this.MI = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.SN = new System.Windows.Forms.MaskedTextBox();
            this.EMail = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Comm = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GuardName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Contact = new System.Windows.Forms.MaskedTextBox();
            this.GuardContact = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblCommittee = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.Bday = new System.Windows.Forms.DateTimePicker();
            this.Age = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGaurdianContactNumber = new System.Windows.Forms.Label();
            this.lblGaurdianName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlUAC = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlUAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // FN
            // 
            this.FN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.FN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.FN.ForeColor = System.Drawing.Color.White;
            this.FN.Location = new System.Drawing.Point(11, 46);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(221, 39);
            this.FN.TabIndex = 1;
            this.FN.WordWrap = false;
            this.FN.Enter += new System.EventHandler(this.FN_Enter);
            this.FN.Leave += new System.EventHandler(this.FN_Leave);
            // 
            // MI
            // 
            this.MI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.MI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MI.ForeColor = System.Drawing.Color.White;
            this.MI.Location = new System.Drawing.Point(239, 46);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(160, 39);
            this.MI.TabIndex = 2;
            this.MI.Enter += new System.EventHandler(this.MI_Enter);
            this.MI.Leave += new System.EventHandler(this.MI_Leave);
            // 
            // LN
            // 
            this.LN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.White;
            this.LN.Location = new System.Drawing.Point(406, 46);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(221, 39);
            this.LN.TabIndex = 3;
            this.LN.Enter += new System.EventHandler(this.LN_Enter);
            this.LN.Leave += new System.EventHandler(this.LN_Leave);
            // 
            // SN
            // 
            this.SN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.SN.BeepOnError = true;
            this.SN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SN.ForeColor = System.Drawing.Color.White;
            this.SN.Location = new System.Drawing.Point(11, 124);
            this.SN.Mask = "\\2\\0000000000";
            this.SN.Name = "SN";
            this.SN.PromptChar = 'X';
            this.SN.Size = new System.Drawing.Size(221, 39);
            this.SN.TabIndex = 4;
            // 
            // EMail
            // 
            this.EMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.EMail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.EMail.ForeColor = System.Drawing.Color.White;
            this.EMail.Location = new System.Drawing.Point(11, 49);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(346, 39);
            this.EMail.TabIndex = 9;
            this.EMail.Enter += new System.EventHandler(this.EMail_Enter);
            this.EMail.Leave += new System.EventHandler(this.EMail_Leave);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Address.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(11, 118);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(543, 39);
            this.Address.TabIndex = 11;
            this.Address.Enter += new System.EventHandler(this.Address_Enter);
            this.Address.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Year.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.Color.White;
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year",
            "5th Year"});
            this.Year.Location = new System.Drawing.Point(239, 123);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(160, 40);
            this.Year.TabIndex = 5;
            // 
            // Comm
            // 
            this.Comm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Comm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comm.ForeColor = System.Drawing.Color.White;
            this.Comm.FormattingEnabled = true;
            this.Comm.Items.AddRange(new object[] {
            "Ways and Means",
            "Events",
            "Academics",
            "Multimedia",
            "Research and Development",
            "Human Resources",
            "Sports",
            "Grievances",
            "Outreach",
            "None (Alay kana)"});
            this.Comm.Location = new System.Drawing.Point(11, 341);
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(388, 33);
            this.Comm.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(575, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 71);
            this.button1.TabIndex = 17;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuardName
            // 
            this.GuardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.GuardName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.GuardName.ForeColor = System.Drawing.Color.White;
            this.GuardName.Location = new System.Drawing.Point(11, 232);
            this.GuardName.Name = "GuardName";
            this.GuardName.Size = new System.Drawing.Size(346, 39);
            this.GuardName.TabIndex = 12;
            this.GuardName.Enter += new System.EventHandler(this.GuardName_Enter);
            this.GuardName.Leave += new System.EventHandler(this.GuardName_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button2.Location = new System.Drawing.Point(9, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(20, 423);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(434, 29);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "I have agreed to the Data Privacy Act of 2012.";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(218, 423);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(234, 25);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Data Privacy Act of 2012.\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Contact.BeepOnError = true;
            this.Contact.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(363, 49);
            this.Contact.Mask = "00000000000";
            this.Contact.Name = "Contact";
            this.Contact.PromptChar = 'X';
            this.Contact.Size = new System.Drawing.Size(191, 39);
            this.Contact.TabIndex = 10;
            // 
            // GuardContact
            // 
            this.GuardContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.GuardContact.BeepOnError = true;
            this.GuardContact.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.GuardContact.ForeColor = System.Drawing.Color.White;
            this.GuardContact.Location = new System.Drawing.Point(363, 233);
            this.GuardContact.Mask = "00000000000";
            this.GuardContact.Name = "GuardContact";
            this.GuardContact.PromptChar = 'X';
            this.GuardContact.Size = new System.Drawing.Size(190, 39);
            this.GuardContact.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(173, 346);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Renew";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(17, 346);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 29);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "New Member";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlInformation.Controls.Add(this.lblBday);
            this.pnlInformation.Controls.Add(this.lblCommittee);
            this.pnlInformation.Controls.Add(this.lblYear);
            this.pnlInformation.Controls.Add(this.label18);
            this.pnlInformation.Controls.Add(this.label5);
            this.pnlInformation.Controls.Add(this.pictureBox1);
            this.pnlInformation.Controls.Add(this.button3);
            this.pnlInformation.Controls.Add(this.label14);
            this.pnlInformation.Controls.Add(this.label13);
            this.pnlInformation.Controls.Add(this.Comm);
            this.pnlInformation.Controls.Add(this.lblStudentNumber);
            this.pnlInformation.Controls.Add(this.lblLastName);
            this.pnlInformation.Controls.Add(this.Bday);
            this.pnlInformation.Controls.Add(this.Age);
            this.pnlInformation.Controls.Add(this.lblMiddleName);
            this.pnlInformation.Controls.Add(this.lblFirstName);
            this.pnlInformation.Controls.Add(this.FN);
            this.pnlInformation.Controls.Add(this.MI);
            this.pnlInformation.Controls.Add(this.LN);
            this.pnlInformation.Controls.Add(this.SN);
            this.pnlInformation.Controls.Add(this.Year);
            this.pnlInformation.Location = new System.Drawing.Point(86, 54);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(853, 469);
            this.pnlInformation.TabIndex = 38;
            this.pnlInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInformation_Paint);
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.ForeColor = System.Drawing.Color.White;
            this.lblBday.Location = new System.Drawing.Point(21, 275);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(145, 20);
            this.lblBday.TabIndex = 58;
            this.lblBday.Text = "Enter your birthday";
            this.lblBday.Visible = false;
            // 
            // lblCommittee
            // 
            this.lblCommittee.AutoSize = true;
            this.lblCommittee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommittee.ForeColor = System.Drawing.Color.White;
            this.lblCommittee.Location = new System.Drawing.Point(21, 383);
            this.lblCommittee.Name = "lblCommittee";
            this.lblCommittee.Size = new System.Drawing.Size(198, 20);
            this.lblCommittee.TabIndex = 57;
            this.lblCommittee.Text = "Please choose a committee";
            this.lblCommittee.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(247, 169);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(130, 20);
            this.lblYear.TabIndex = 56;
            this.lblYear.Text = "Choose your year";
            this.lblYear.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(11, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 32);
            this.label18.TabIndex = 55;
            this.label18.Text = " Your birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(658, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 75);
            this.label5.TabIndex = 54;
            this.label5.Text = "We are not just an \r\norganization\r\nwe are a FAMILY.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(659, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(323, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "NEXT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(19, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 32);
            this.label14.TabIndex = 48;
            this.label14.Text = "Choose a committee";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(277, 32);
            this.label13.TabIndex = 47;
            this.label13.Text = "Your basic information";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumber.Location = new System.Drawing.Point(21, 169);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(167, 20);
            this.lblStudentNumber.TabIndex = 45;
            this.lblStudentNumber.Text = "Enter Student Number";
            this.lblStudentNumber.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(413, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(125, 20);
            this.lblLastName.TabIndex = 44;
            this.lblLastName.Text = "Enter Last Name";
            this.lblLastName.Visible = false;
            // 
            // Bday
            // 
            this.Bday.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Bday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Bday.Location = new System.Drawing.Point(11, 233);
            this.Bday.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.Bday.Name = "Bday";
            this.Bday.Size = new System.Drawing.Size(173, 39);
            this.Bday.TabIndex = 6;
            this.Bday.Value = new System.DateTime(2018, 5, 6, 11, 30, 34, 0);
            this.Bday.ValueChanged += new System.EventHandler(this.Bday_ValueChanged);
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Age.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(193, 233);
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Size = new System.Drawing.Size(39, 39);
            this.Age.TabIndex = 36;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.White;
            this.lblMiddleName.Location = new System.Drawing.Point(247, 91);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(142, 20);
            this.lblMiddleName.TabIndex = 43;
            this.lblMiddleName.Text = "Enter Middle Initial";
            this.lblMiddleName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(21, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(127, 20);
            this.lblFirstName.TabIndex = 42;
            this.lblFirstName.Text = "Enter First Name";
            this.lblFirstName.Visible = false;
            // 
            // pnlContact
            // 
            this.pnlContact.BackColor = System.Drawing.Color.Transparent;
            this.pnlContact.Controls.Add(this.label2);
            this.pnlContact.Controls.Add(this.lblMembership);
            this.pnlContact.Controls.Add(this.label16);
            this.pnlContact.Controls.Add(this.pictureBox2);
            this.pnlContact.Controls.Add(this.button5);
            this.pnlContact.Controls.Add(this.button4);
            this.pnlContact.Controls.Add(this.label12);
            this.pnlContact.Controls.Add(this.label11);
            this.pnlContact.Controls.Add(this.lblGaurdianContactNumber);
            this.pnlContact.Controls.Add(this.lblGaurdianName);
            this.pnlContact.Controls.Add(this.lblAddress);
            this.pnlContact.Controls.Add(this.lblPhoneNumber);
            this.pnlContact.Controls.Add(this.lblEmail);
            this.pnlContact.Controls.Add(this.radioButton1);
            this.pnlContact.Controls.Add(this.radioButton2);
            this.pnlContact.Controls.Add(this.GuardName);
            this.pnlContact.Controls.Add(this.GuardContact);
            this.pnlContact.Controls.Add(this.EMail);
            this.pnlContact.Controls.Add(this.Address);
            this.pnlContact.Controls.Add(this.Contact);
            this.pnlContact.Location = new System.Drawing.Point(86, 54);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(853, 469);
            this.pnlContact.TabIndex = 11;
            this.pnlContact.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContact_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 57;
            this.label2.Text = "Membership";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.BackColor = System.Drawing.Color.Transparent;
            this.lblMembership.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMembership.ForeColor = System.Drawing.Color.White;
            this.lblMembership.Location = new System.Drawing.Point(272, 352);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(201, 20);
            this.lblMembership.TabIndex = 56;
            this.lblMembership.Text = "Please select a membership";
            this.lblMembership.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(619, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 75);
            this.label16.TabIndex = 55;
            this.label16.Text = "Your personal\r\ninformation\r\nis private and safe";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(620, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 200);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(18, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 57);
            this.button5.TabIndex = 51;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(246, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 57);
            this.button4.TabIndex = 50;
            this.button4.Text = "NEXT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 32);
            this.label12.TabIndex = 49;
            this.label12.Text = "Guardian contact details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 32);
            this.label11.TabIndex = 48;
            this.label11.Text = "Your contact details";
            // 
            // lblGaurdianContactNumber
            // 
            this.lblGaurdianContactNumber.AutoSize = true;
            this.lblGaurdianContactNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGaurdianContactNumber.ForeColor = System.Drawing.Color.White;
            this.lblGaurdianContactNumber.Location = new System.Drawing.Point(359, 277);
            this.lblGaurdianContactNumber.Name = "lblGaurdianContactNumber";
            this.lblGaurdianContactNumber.Size = new System.Drawing.Size(153, 20);
            this.lblGaurdianContactNumber.TabIndex = 47;
            this.lblGaurdianContactNumber.Text = "Enter phone number";
            this.lblGaurdianContactNumber.Visible = false;
            // 
            // lblGaurdianName
            // 
            this.lblGaurdianName.AutoSize = true;
            this.lblGaurdianName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaurdianName.ForeColor = System.Drawing.Color.White;
            this.lblGaurdianName.Location = new System.Drawing.Point(25, 277);
            this.lblGaurdianName.Name = "lblGaurdianName";
            this.lblGaurdianName.Size = new System.Drawing.Size(89, 20);
            this.lblGaurdianName.TabIndex = 46;
            this.lblGaurdianName.Text = "Enter name";
            this.lblGaurdianName.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(25, 162);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(148, 20);
            this.lblAddress.TabIndex = 45;
            this.lblAddress.Text = "Enter home address";
            this.lblAddress.Visible = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(362, 91);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(192, 20);
            this.lblPhoneNumber.TabIndex = 44;
            this.lblPhoneNumber.Text = "Enter your Phone Number";
            this.lblPhoneNumber.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(25, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 20);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Enter your email";
            this.lblEmail.Visible = false;
            // 
            // pnlUAC
            // 
            this.pnlUAC.BackColor = System.Drawing.Color.Transparent;
            this.pnlUAC.Controls.Add(this.button6);
            this.pnlUAC.Controls.Add(this.label17);
            this.pnlUAC.Controls.Add(this.pictureBox3);
            this.pnlUAC.Controls.Add(this.label15);
            this.pnlUAC.Controls.Add(this.richTextBox1);
            this.pnlUAC.Controls.Add(this.linkLabel1);
            this.pnlUAC.Controls.Add(this.button1);
            this.pnlUAC.Controls.Add(this.checkBox1);
            this.pnlUAC.Location = new System.Drawing.Point(86, 54);
            this.pnlUAC.Name = "pnlUAC";
            this.pnlUAC.Size = new System.Drawing.Size(853, 469);
            this.pnlUAC.TabIndex = 41;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button6.Location = new System.Drawing.Point(14, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 42;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(648, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 50);
            this.label17.TabIndex = 55;
            this.label17.Text = "Your data is\r\nsafe with us";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::System.Properties.Resources.security_uac;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(620, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 200);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(50, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(267, 40);
            this.label15.TabIndex = 18;
            this.label15.Text = "Privacy and Terms";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(540, 351);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // New_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::System.Properties.Resources.NewMemberBackgroundVersion2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.pnlUAC);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.New_Member_Load);
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlUAC.ResumeLayout(false);
            this.pnlUAC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Windows.Forms.TextBox FN;
        private Windows.Forms.TextBox MI;
        private Windows.Forms.TextBox LN;
        private Windows.Forms.MaskedTextBox SN;
        private Windows.Forms.TextBox EMail;
        private Windows.Forms.TextBox Address;
        private Windows.Forms.ComboBox Year;
        private Windows.Forms.ComboBox Comm;
        private Windows.Forms.Button button1;
        private Windows.Forms.TextBox GuardName;
        private Windows.Forms.Button button2;
        private DirectoryServices.DirectoryEntry directoryEntry1;
        private Windows.Forms.CheckBox checkBox1;
        private Windows.Forms.LinkLabel linkLabel1;
        private Windows.Forms.MaskedTextBox Contact;
        private Windows.Forms.MaskedTextBox GuardContact;
        private Windows.Forms.RadioButton radioButton2;
        private Windows.Forms.RadioButton radioButton1;
        private Windows.Forms.Panel pnlInformation;
        private Windows.Forms.Panel pnlContact;
        private Windows.Forms.Panel pnlUAC;
        private Windows.Forms.Label lblStudentNumber;
        private Windows.Forms.Label lblLastName;
        private Windows.Forms.Label lblMiddleName;
        private Windows.Forms.Label lblFirstName;
        private Windows.Forms.DateTimePicker Bday;
        private Windows.Forms.TextBox Age;
        private Windows.Forms.Label lblGaurdianContactNumber;
        private Windows.Forms.Label lblGaurdianName;
        private Windows.Forms.Label lblAddress;
        private Windows.Forms.Label lblPhoneNumber;
        private Windows.Forms.Label lblEmail;
        private Windows.Forms.Button button3;
        private Windows.Forms.Label label14;
        private Windows.Forms.Label label13;
        private Windows.Forms.Button button5;
        private Windows.Forms.Button button4;
        private Windows.Forms.Label label12;
        private Windows.Forms.Label label11;
        private Windows.Forms.RichTextBox richTextBox1;
        private Windows.Forms.Label label15;
        private Windows.Forms.PictureBox pictureBox2;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.Label label18;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label16;
        private Windows.Forms.Label label17;
        private Windows.Forms.PictureBox pictureBox3;
        private Windows.Forms.Label lblYear;
        private Windows.Forms.Label lblCommittee;
        private Windows.Forms.Label lblBday;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label lblMembership;
        private Windows.Forms.Button button6;
    }
}