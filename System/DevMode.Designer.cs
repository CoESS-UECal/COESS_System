namespace System
{
    partial class DevMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevMode));
            this.MemberListView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SNColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.lblSearchSN = new System.Windows.Forms.Label();
            this.mtbSearchSN = new System.Windows.Forms.MaskedTextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.tbMembership = new System.Windows.Forms.TextBox();
            this.lblMembership = new System.Windows.Forms.Label();
            this.tbCommittee = new System.Windows.Forms.TextBox();
            this.lblCommittee = new System.Windows.Forms.Label();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbGuardianContact = new System.Windows.Forms.TextBox();
            this.tbGuardianName = new System.Windows.Forms.TextBox();
            this.tbYrLvl = new System.Windows.Forms.TextBox();
            this.tbContactNum = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblGuardianContact = new System.Windows.Forms.Label();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.lblYrLvl = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOldMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemberList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpMemberList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberListView
            // 
            this.MemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.SNColumn,
            this.NameColumn});
            this.MemberListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberListView.FullRowSelect = true;
            this.MemberListView.GridLines = true;
            this.MemberListView.HideSelection = false;
            this.MemberListView.Location = new System.Drawing.Point(6, 20);
            this.MemberListView.MultiSelect = false;
            this.MemberListView.Name = "MemberListView";
            this.MemberListView.Size = new System.Drawing.Size(562, 488);
            this.MemberListView.TabIndex = 0;
            this.MemberListView.UseCompatibleStateImageBehavior = false;
            this.MemberListView.View = System.Windows.Forms.View.Details;
            this.MemberListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MemberListView_ColumnClick);
            this.MemberListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MemberListView_MouseDoubleClick);
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 35;
            // 
            // SNColumn
            // 
            this.SNColumn.Text = "Student Number";
            this.SNColumn.Width = 200;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 320;
            // 
            // pbUserPic
            // 
            this.pbUserPic.BackColor = System.Drawing.Color.Transparent;
            this.pbUserPic.BackgroundImage = global::System.Properties.Resources.logo;
            this.pbUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserPic.ImageLocation = "";
            this.pbUserPic.Location = new System.Drawing.Point(744, 100);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(123, 125);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 1;
            this.pbUserPic.TabStop = false;
            this.pbUserPic.DoubleClick += new System.EventHandler(this.pbUserPic_DoubleClick);
            // 
            // lblSearchSN
            // 
            this.lblSearchSN.AutoSize = true;
            this.lblSearchSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSN.ForeColor = System.Drawing.Color.White;
            this.lblSearchSN.Location = new System.Drawing.Point(621, 72);
            this.lblSearchSN.Name = "lblSearchSN";
            this.lblSearchSN.Size = new System.Drawing.Size(186, 21);
            this.lblSearchSN.TabIndex = 2;
            this.lblSearchSN.Text = "Enter Student Number:";
            // 
            // mtbSearchSN
            // 
            this.mtbSearchSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.mtbSearchSN.BeepOnError = true;
            this.mtbSearchSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSearchSN.ForeColor = System.Drawing.Color.White;
            this.mtbSearchSN.Location = new System.Drawing.Point(819, 64);
            this.mtbSearchSN.Mask = "00000000000";
            this.mtbSearchSN.Name = "mtbSearchSN";
            this.mtbSearchSN.Size = new System.Drawing.Size(165, 29);
            this.mtbSearchSN.TabIndex = 10;
            this.mtbSearchSN.TextChanged += new System.EventHandler(this.mtbSearchSN_TextChanged);
            // 
            // tbBirthday
            // 
            this.tbBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirthday.ForeColor = System.Drawing.Color.White;
            this.tbBirthday.Location = new System.Drawing.Point(710, 268);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.ReadOnly = true;
            this.tbBirthday.Size = new System.Drawing.Size(97, 29);
            this.tbBirthday.TabIndex = 34;
            this.tbBirthday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbBirthday_DoubleClick);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(622, 271);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(83, 21);
            this.lblBirthday.TabIndex = 33;
            this.lblBirthday.Text = "Birthday: ";
            // 
            // tbMembership
            // 
            this.tbMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbMembership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMembership.ForeColor = System.Drawing.Color.White;
            this.tbMembership.Location = new System.Drawing.Point(735, 232);
            this.tbMembership.Name = "tbMembership";
            this.tbMembership.ReadOnly = true;
            this.tbMembership.Size = new System.Drawing.Size(111, 29);
            this.tbMembership.TabIndex = 32;
            this.tbMembership.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbMembership_MouseDoubleClick);
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.BackColor = System.Drawing.Color.Transparent;
            this.lblMembership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembership.ForeColor = System.Drawing.Color.White;
            this.lblMembership.Location = new System.Drawing.Point(622, 235);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(114, 21);
            this.lblMembership.TabIndex = 31;
            this.lblMembership.Text = "Membership: ";
            // 
            // tbCommittee
            // 
            this.tbCommittee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbCommittee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommittee.ForeColor = System.Drawing.Color.White;
            this.tbCommittee.Location = new System.Drawing.Point(718, 448);
            this.tbCommittee.Name = "tbCommittee";
            this.tbCommittee.ReadOnly = true;
            this.tbCommittee.Size = new System.Drawing.Size(266, 29);
            this.tbCommittee.TabIndex = 30;
            this.tbCommittee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbCommittee_MouseDoubleClick);
            // 
            // lblCommittee
            // 
            this.lblCommittee.AutoSize = true;
            this.lblCommittee.BackColor = System.Drawing.Color.Transparent;
            this.lblCommittee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommittee.ForeColor = System.Drawing.Color.White;
            this.lblCommittee.Location = new System.Drawing.Point(621, 451);
            this.lblCommittee.Name = "lblCommittee";
            this.lblCommittee.Size = new System.Drawing.Size(99, 21);
            this.lblCommittee.TabIndex = 29;
            this.lblCommittee.Text = "Committee:";
            // 
            // tbSN
            // 
            this.tbSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSN.ForeColor = System.Drawing.Color.White;
            this.tbSN.Location = new System.Drawing.Point(761, 304);
            this.tbSN.Name = "tbSN";
            this.tbSN.ReadOnly = true;
            this.tbSN.Size = new System.Drawing.Size(223, 29);
            this.tbSN.TabIndex = 28;
            this.tbSN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSN_MouseDoubleClick);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.ForeColor = System.Drawing.Color.White;
            this.lblSN.Location = new System.Drawing.Point(621, 307);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(142, 21);
            this.lblSN.TabIndex = 27;
            this.lblSN.Text = "Student Number:";
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.ForeColor = System.Drawing.Color.White;
            this.tbAge.Location = new System.Drawing.Point(902, 232);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(82, 29);
            this.tbAge.TabIndex = 26;
            this.tbAge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbAge_MouseDoubleClick);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(852, 235);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 21);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age:";
            // 
            // tbGuardianContact
            // 
            this.tbGuardianContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbGuardianContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuardianContact.ForeColor = System.Drawing.Color.White;
            this.tbGuardianContact.Location = new System.Drawing.Point(842, 520);
            this.tbGuardianContact.Name = "tbGuardianContact";
            this.tbGuardianContact.ReadOnly = true;
            this.tbGuardianContact.Size = new System.Drawing.Size(142, 29);
            this.tbGuardianContact.TabIndex = 24;
            this.tbGuardianContact.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGuardianContact_MouseDoubleClick);
            // 
            // tbGuardianName
            // 
            this.tbGuardianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbGuardianName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuardianName.ForeColor = System.Drawing.Color.White;
            this.tbGuardianName.Location = new System.Drawing.Point(761, 484);
            this.tbGuardianName.Name = "tbGuardianName";
            this.tbGuardianName.ReadOnly = true;
            this.tbGuardianName.Size = new System.Drawing.Size(223, 29);
            this.tbGuardianName.TabIndex = 23;
            this.tbGuardianName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGuardianName_MouseDoubleClick);
            // 
            // tbYrLvl
            // 
            this.tbYrLvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbYrLvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYrLvl.ForeColor = System.Drawing.Color.White;
            this.tbYrLvl.Location = new System.Drawing.Point(902, 268);
            this.tbYrLvl.Name = "tbYrLvl";
            this.tbYrLvl.ReadOnly = true;
            this.tbYrLvl.Size = new System.Drawing.Size(82, 29);
            this.tbYrLvl.TabIndex = 22;
            this.tbYrLvl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbYrLvl_MouseDoubleClick);
            // 
            // tbContactNum
            // 
            this.tbContactNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactNum.ForeColor = System.Drawing.Color.White;
            this.tbContactNum.Location = new System.Drawing.Point(768, 412);
            this.tbContactNum.Name = "tbContactNum";
            this.tbContactNum.ReadOnly = true;
            this.tbContactNum.Size = new System.Drawing.Size(216, 29);
            this.tbContactNum.TabIndex = 21;
            this.tbContactNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbContactNum_MouseDoubleClick);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.White;
            this.tbAddress.Location = new System.Drawing.Point(701, 376);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(283, 29);
            this.tbAddress.TabIndex = 20;
            this.tbAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbAddress_MouseDoubleClick);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(687, 340);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(297, 29);
            this.tbName.TabIndex = 19;
            this.tbName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDoubleClick);
            // 
            // lblGuardianContact
            // 
            this.lblGuardianContact.AutoSize = true;
            this.lblGuardianContact.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianContact.ForeColor = System.Drawing.Color.White;
            this.lblGuardianContact.Location = new System.Drawing.Point(622, 523);
            this.lblGuardianContact.Name = "lblGuardianContact";
            this.lblGuardianContact.Size = new System.Drawing.Size(215, 21);
            this.lblGuardianContact.TabIndex = 18;
            this.lblGuardianContact.Text = "Guardian Contact Number:";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.ForeColor = System.Drawing.Color.White;
            this.lblGuardianName.Location = new System.Drawing.Point(621, 487);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(134, 21);
            this.lblGuardianName.TabIndex = 17;
            this.lblGuardianName.Text = "Guardian Name:";
            // 
            // lblYrLvl
            // 
            this.lblYrLvl.AutoSize = true;
            this.lblYrLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblYrLvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYrLvl.ForeColor = System.Drawing.Color.White;
            this.lblYrLvl.Location = new System.Drawing.Point(805, 271);
            this.lblYrLvl.Name = "lblYrLvl";
            this.lblYrLvl.Size = new System.Drawing.Size(91, 21);
            this.lblYrLvl.TabIndex = 16;
            this.lblYrLvl.Text = "Year Level:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.ForeColor = System.Drawing.Color.White;
            this.lblContactNum.Location = new System.Drawing.Point(621, 415);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(141, 21);
            this.lblContactNum.TabIndex = 15;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(621, 379);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 21);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(621, 343);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::System.Properties.Resources.BACK;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.BackButton.Location = new System.Drawing.Point(9, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(35, 35);
            this.BackButton.TabIndex = 32;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1024, 25);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshListToolStripMenuItem,
            this.clearMemberInfoToolStripMenuItem,
            this.countNewMemberToolStripMenuItem,
            this.countOldMemberToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // clearMemberInfoToolStripMenuItem
            // 
            this.clearMemberInfoToolStripMenuItem.Name = "clearMemberInfoToolStripMenuItem";
            this.clearMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.clearMemberInfoToolStripMenuItem.Text = "Clear Member Info";
            this.clearMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.clearMemberInfoToolStripMenuItem_Click);
            // 
            // countNewMemberToolStripMenuItem
            // 
            this.countNewMemberToolStripMenuItem.Name = "countNewMemberToolStripMenuItem";
            this.countNewMemberToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.countNewMemberToolStripMenuItem.Text = "Count New Member";
            this.countNewMemberToolStripMenuItem.Click += new System.EventHandler(this.countNewMemberToolStripMenuItem_Click);
            // 
            // countOldMemberToolStripMenuItem
            // 
            this.countOldMemberToolStripMenuItem.Name = "countOldMemberToolStripMenuItem";
            this.countOldMemberToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.countOldMemberToolStripMenuItem.Text = "Count Old Member";
            this.countOldMemberToolStripMenuItem.Click += new System.EventHandler(this.countOldMemberToolStripMenuItem_Click);
            // 
            // grpMemberList
            // 
            this.grpMemberList.BackColor = System.Drawing.Color.Transparent;
            this.grpMemberList.Controls.Add(this.MemberListView);
            this.grpMemberList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpMemberList.ForeColor = System.Drawing.Color.White;
            this.grpMemberList.Location = new System.Drawing.Point(12, 50);
            this.grpMemberList.Name = "grpMemberList";
            this.grpMemberList.Size = new System.Drawing.Size(575, 514);
            this.grpMemberList.TabIndex = 11;
            this.grpMemberList.TabStop = false;
            this.grpMemberList.Text = "Member List";
            // 
            // DevMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::System.Properties.Resources.NewMemberBackgroundVersion2;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.tbYrLvl);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.grpMemberList);
            this.Controls.Add(this.tbMembership);
            this.Controls.Add(this.mtbSearchSN);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.tbCommittee);
            this.Controls.Add(this.lblSearchSN);
            this.Controls.Add(this.lblCommittee);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.pbUserPic);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.tbGuardianContact);
            this.Controls.Add(this.lblYrLvl);
            this.Controls.Add(this.tbGuardianName);
            this.Controls.Add(this.lblGuardianName);
            this.Controls.Add(this.lblGuardianContact);
            this.Controls.Add(this.tbContactNum);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAddress);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DevMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Member_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMemberList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.ListView MemberListView;
        private Windows.Forms.PictureBox pbUserPic;
        private Windows.Forms.Label lblSearchSN;
        private Windows.Forms.MaskedTextBox mtbSearchSN;
        private Windows.Forms.TextBox tbGuardianContact;
        private Windows.Forms.TextBox tbGuardianName;
        private Windows.Forms.TextBox tbYrLvl;
        private Windows.Forms.TextBox tbContactNum;
        private Windows.Forms.TextBox tbAddress;
        private Windows.Forms.TextBox tbName;
        private Windows.Forms.Label lblGuardianContact;
        private Windows.Forms.Label lblGuardianName;
        private Windows.Forms.Label lblYrLvl;
        private Windows.Forms.Label lblContactNum;
        private Windows.Forms.Label lblAddress;
        private Windows.Forms.Label lblName;
        private Windows.Forms.Button BackButton;
        private Windows.Forms.ColumnHeader IDHeader;
        private Windows.Forms.ColumnHeader SNColumn;
        private Windows.Forms.ColumnHeader NameColumn;
        private Windows.Forms.OpenFileDialog openFileDialog1;
        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem clearMemberInfoToolStripMenuItem;
        private Windows.Forms.TextBox tbAge;
        private Windows.Forms.Label lblAge;
        private Windows.Forms.ToolStripMenuItem countNewMemberToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem countOldMemberToolStripMenuItem;
        private Windows.Forms.TextBox tbBirthday;
        private Windows.Forms.Label lblBirthday;
        private Windows.Forms.TextBox tbMembership;
        private Windows.Forms.Label lblMembership;
        private Windows.Forms.TextBox tbCommittee;
        private Windows.Forms.Label lblCommittee;
        private Windows.Forms.TextBox tbSN;
        private Windows.Forms.Label lblSN;
        private Windows.Forms.GroupBox grpMemberList;
    }
}