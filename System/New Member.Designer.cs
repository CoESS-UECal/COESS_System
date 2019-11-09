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
            this.Bday = new System.Windows.Forms.DateTimePicker();
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
            this.Age = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FN
            // 
            this.FN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.FN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.White;
            this.FN.Location = new System.Drawing.Point(28, 171);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(170, 33);
            this.FN.TabIndex = 2;
            this.FN.Enter += new System.EventHandler(this.FN_Enter);
            this.FN.Leave += new System.EventHandler(this.FN_Leave);
            // 
            // MI
            // 
            this.MI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.MI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MI.ForeColor = System.Drawing.Color.White;
            this.MI.Location = new System.Drawing.Point(204, 171);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(120, 33);
            this.MI.TabIndex = 3;
            this.MI.Enter += new System.EventHandler(this.MI_Enter);
            this.MI.Leave += new System.EventHandler(this.MI_Leave);
            // 
            // LN
            // 
            this.LN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.White;
            this.LN.Location = new System.Drawing.Point(330, 171);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(170, 33);
            this.LN.TabIndex = 4;
            this.LN.Enter += new System.EventHandler(this.LN_Enter);
            this.LN.Leave += new System.EventHandler(this.LN_Leave);
            // 
            // SN
            // 
            this.SN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.SN.BeepOnError = true;
            this.SN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SN.ForeColor = System.Drawing.Color.White;
            this.SN.Location = new System.Drawing.Point(28, 236);
            this.SN.Mask = "\\2\\0000000000";
            this.SN.Name = "SN";
            this.SN.PromptChar = 'X';
            this.SN.Size = new System.Drawing.Size(154, 33);
            this.SN.TabIndex = 5;
            // 
            // EMail
            // 
            this.EMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.EMail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMail.ForeColor = System.Drawing.Color.White;
            this.EMail.Location = new System.Drawing.Point(28, 301);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(154, 33);
            this.EMail.TabIndex = 6;
            this.EMail.Enter += new System.EventHandler(this.EMail_Enter);
            this.EMail.Leave += new System.EventHandler(this.EMail_Leave);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(28, 366);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(472, 33);
            this.Address.TabIndex = 7;
            this.Address.Enter += new System.EventHandler(this.Address_Enter);
            this.Address.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // Bday
            // 
            this.Bday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Bday.Location = new System.Drawing.Point(187, 300);
            this.Bday.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.Bday.Name = "Bday";
            this.Bday.Size = new System.Drawing.Size(154, 33);
            this.Bday.TabIndex = 9;
            this.Bday.Value = new System.DateTime(2018, 5, 6, 11, 30, 34, 0);
            this.Bday.ValueChanged += new System.EventHandler(this.Bday_ValueChanged);
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Year.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.Color.White;
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th"});
            this.Year.Location = new System.Drawing.Point(346, 236);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(154, 33);
            this.Year.TabIndex = 10;
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
            this.Comm.Location = new System.Drawing.Point(524, 235);
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(472, 33);
            this.Comm.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 88);
            this.button1.TabIndex = 16;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuardName
            // 
            this.GuardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.GuardName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardName.ForeColor = System.Drawing.Color.White;
            this.GuardName.Location = new System.Drawing.Point(524, 171);
            this.GuardName.Name = "GuardName";
            this.GuardName.Size = new System.Drawing.Size(233, 33);
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
            this.checkBox1.Location = new System.Drawing.Point(524, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(434, 29);
            this.checkBox1.TabIndex = 14;
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
            this.linkLabel1.Location = new System.Drawing.Point(724, 370);
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
            this.Contact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(187, 236);
            this.Contact.Mask = "00000000000";
            this.Contact.Name = "Contact";
            this.Contact.PromptChar = 'X';
            this.Contact.Size = new System.Drawing.Size(154, 33);
            this.Contact.TabIndex = 8;
            // 
            // GuardContact
            // 
            this.GuardContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.GuardContact.BeepOnError = true;
            this.GuardContact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardContact.ForeColor = System.Drawing.Color.White;
            this.GuardContact.Location = new System.Drawing.Point(764, 171);
            this.GuardContact.Mask = "00000000000";
            this.GuardContact.Name = "GuardContact";
            this.GuardContact.PromptChar = 'X';
            this.GuardContact.Size = new System.Drawing.Size(233, 33);
            this.GuardContact.TabIndex = 13;
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Age.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(346, 301);
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Size = new System.Drawing.Size(154, 33);
            this.Age.TabIndex = 36;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(703, 304);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 29);
            this.radioButton2.TabIndex = 1;
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
            this.radioButton1.Location = new System.Drawing.Point(524, 302);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "New Member";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 65);
            this.label1.TabIndex = 37;
            this.label1.Text = "REGISTRATION";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.GuardContact);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GuardName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Comm);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Bday);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.EMail);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.MI);
            this.Controls.Add(this.FN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.New_Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.TextBox FN;
        private Windows.Forms.TextBox MI;
        private Windows.Forms.TextBox LN;
        private Windows.Forms.MaskedTextBox SN;
        private Windows.Forms.TextBox EMail;
        private Windows.Forms.TextBox Address;
        private Windows.Forms.DateTimePicker Bday;
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
        private Windows.Forms.TextBox Age;
        private Windows.Forms.RadioButton radioButton2;
        private Windows.Forms.RadioButton radioButton1;
        private Windows.Forms.Label label1;
    }
}