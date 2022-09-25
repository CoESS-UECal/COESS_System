namespace System
{
    partial class Member_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_List));
            this.MemberListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchSN = new System.Windows.Forms.Label();
            this.pbUserPic = new System.Windows.Forms.MaskedTextBox();
            this.gbMemberList = new System.Windows.Forms.GroupBox();
            this.gbMemberInfo = new System.Windows.Forms.GroupBox();
            this.gbGuardianInfo = new System.Windows.Forms.GroupBox();
            this.tbGuardianContact = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.lblGuardianContact = new System.Windows.Forms.Label();
            this.tbGuardianName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbYrLvl = new System.Windows.Forms.TextBox();
            this.tbContactNum = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblYrLvl = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOldMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMemberList.SuspendLayout();
            this.gbMemberInfo.SuspendLayout();
            this.gbGuardianInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberListView
            // 
            this.MemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
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
            this.MemberListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.MemberListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MemberListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Number";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 320;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::System.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(134, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lblSearchSN
            // 
            this.lblSearchSN.AutoSize = true;
            this.lblSearchSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchSN.ForeColor = System.Drawing.Color.White;
            this.lblSearchSN.Location = new System.Drawing.Point(621, 68);
            this.lblSearchSN.Name = "lblSearchSN";
            this.lblSearchSN.Size = new System.Drawing.Size(186, 21);
            this.lblSearchSN.TabIndex = 2;
            this.lblSearchSN.Text = "Enter Student Number:";
            // 
            // pbUserPic
            // 
            this.pbUserPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.pbUserPic.BeepOnError = true;
            this.pbUserPic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.pbUserPic.ForeColor = System.Drawing.Color.White;
            this.pbUserPic.Location = new System.Drawing.Point(819, 64);
            this.pbUserPic.Mask = "00000000000";
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(165, 29);
            this.pbUserPic.TabIndex = 10;
            this.pbUserPic.TextChanged += new System.EventHandler(this.mtbSearchSN_TextChanged);
            // 
            // gbMemberList
            // 
            this.gbMemberList.BackColor = System.Drawing.Color.Transparent;
            this.gbMemberList.Controls.Add(this.MemberListView);
            this.gbMemberList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbMemberList.ForeColor = System.Drawing.Color.White;
            this.gbMemberList.Location = new System.Drawing.Point(12, 50);
            this.gbMemberList.Name = "gbMemberList";
            this.gbMemberList.Size = new System.Drawing.Size(575, 514);
            this.gbMemberList.TabIndex = 11;
            this.gbMemberList.TabStop = false;
            this.gbMemberList.Text = "Member List";
            // 
            // gbMemberInfo
            // 
            this.gbMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbMemberInfo.Controls.Add(this.gbGuardianInfo);
            this.gbMemberInfo.Controls.Add(this.tbAge);
            this.gbMemberInfo.Controls.Add(this.lblAge);
            this.gbMemberInfo.Controls.Add(this.tbYrLvl);
            this.gbMemberInfo.Controls.Add(this.tbContactNum);
            this.gbMemberInfo.Controls.Add(this.tbName);
            this.gbMemberInfo.Controls.Add(this.lblYrLvl);
            this.gbMemberInfo.Controls.Add(this.lblContactNum);
            this.gbMemberInfo.Controls.Add(this.lblName);
            this.gbMemberInfo.Controls.Add(this.pictureBox1);
            this.gbMemberInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbMemberInfo.ForeColor = System.Drawing.Color.White;
            this.gbMemberInfo.Location = new System.Drawing.Point(593, 99);
            this.gbMemberInfo.Name = "gbMemberInfo";
            this.gbMemberInfo.Size = new System.Drawing.Size(419, 465);
            this.gbMemberInfo.TabIndex = 12;
            this.gbMemberInfo.TabStop = false;
            this.gbMemberInfo.Text = "Member Info";
            // 
            // gbGuardianInfo
            // 
            this.gbGuardianInfo.Controls.Add(this.tbGuardianContact);
            this.gbGuardianInfo.Controls.Add(this.lblGuardianName);
            this.gbGuardianInfo.Controls.Add(this.lblGuardianContact);
            this.gbGuardianInfo.Controls.Add(this.tbGuardianName);
            this.gbGuardianInfo.ForeColor = System.Drawing.Color.White;
            this.gbGuardianInfo.Location = new System.Drawing.Point(0, 332);
            this.gbGuardianInfo.Name = "gbGuardianInfo";
            this.gbGuardianInfo.Size = new System.Drawing.Size(419, 133);
            this.gbGuardianInfo.TabIndex = 27;
            this.gbGuardianInfo.TabStop = false;
            this.gbGuardianInfo.Text = "Guardian Info";
            // 
            // tbGuardianContact
            // 
            this.tbGuardianContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbGuardianContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbGuardianContact.ForeColor = System.Drawing.Color.White;
            this.tbGuardianContact.Location = new System.Drawing.Point(153, 75);
            this.tbGuardianContact.Name = "tbGuardianContact";
            this.tbGuardianContact.ReadOnly = true;
            this.tbGuardianContact.Size = new System.Drawing.Size(260, 29);
            this.tbGuardianContact.TabIndex = 23;
            this.tbGuardianContact.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGuardianContact_MouseDoubleClick);
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuardianName.ForeColor = System.Drawing.Color.White;
            this.lblGuardianName.Location = new System.Drawing.Point(6, 30);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(60, 21);
            this.lblGuardianName.TabIndex = 17;
            this.lblGuardianName.Text = "Name:";
            // 
            // lblGuardianContact
            // 
            this.lblGuardianContact.AutoSize = true;
            this.lblGuardianContact.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuardianContact.ForeColor = System.Drawing.Color.White;
            this.lblGuardianContact.Location = new System.Drawing.Point(6, 78);
            this.lblGuardianContact.Name = "lblGuardianContact";
            this.lblGuardianContact.Size = new System.Drawing.Size(141, 21);
            this.lblGuardianContact.TabIndex = 18;
            this.lblGuardianContact.Text = "Contact Number:";
            // 
            // tbGuardianName
            // 
            this.tbGuardianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbGuardianName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbGuardianName.ForeColor = System.Drawing.Color.White;
            this.tbGuardianName.Location = new System.Drawing.Point(77, 27);
            this.tbGuardianName.Name = "tbGuardianName";
            this.tbGuardianName.ReadOnly = true;
            this.tbGuardianName.Size = new System.Drawing.Size(336, 29);
            this.tbGuardianName.TabIndex = 24;
            this.tbGuardianName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbGuardianName_MouseDoubleClick);
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbAge.ForeColor = System.Drawing.Color.White;
            this.tbAge.Location = new System.Drawing.Point(360, 256);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(53, 29);
            this.tbAge.TabIndex = 26;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(310, 259);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 21);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age:";
            // 
            // tbYrLvl
            // 
            this.tbYrLvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbYrLvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbYrLvl.ForeColor = System.Drawing.Color.White;
            this.tbYrLvl.Location = new System.Drawing.Point(98, 296);
            this.tbYrLvl.Name = "tbYrLvl";
            this.tbYrLvl.ReadOnly = true;
            this.tbYrLvl.Size = new System.Drawing.Size(51, 29);
            this.tbYrLvl.TabIndex = 22;
            this.tbYrLvl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbYrLvl_MouseDoubleClick);
            // 
            // tbContactNum
            // 
            this.tbContactNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbContactNum.ForeColor = System.Drawing.Color.White;
            this.tbContactNum.Location = new System.Drawing.Point(292, 296);
            this.tbContactNum.Name = "tbContactNum";
            this.tbContactNum.ReadOnly = true;
            this.tbContactNum.Size = new System.Drawing.Size(120, 29);
            this.tbContactNum.TabIndex = 21;
            this.tbContactNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbContactNum_MouseDoubleClick);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(73, 256);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(234, 29);
            this.tbName.TabIndex = 19;
            this.tbName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDoubleClick);
            // 
            // lblYrLvl
            // 
            this.lblYrLvl.AutoSize = true;
            this.lblYrLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblYrLvl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYrLvl.ForeColor = System.Drawing.Color.White;
            this.lblYrLvl.Location = new System.Drawing.Point(6, 299);
            this.lblYrLvl.Name = "lblYrLvl";
            this.lblYrLvl.Size = new System.Drawing.Size(91, 21);
            this.lblYrLvl.TabIndex = 16;
            this.lblYrLvl.Text = "Year Level:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactNum.ForeColor = System.Drawing.Color.White;
            this.lblContactNum.Location = new System.Drawing.Point(150, 299);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(141, 21);
            this.lblContactNum.TabIndex = 15;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(6, 259);
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
            // Member_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::System.Properties.Resources.NewMemberBackgroundVersion2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.gbMemberList);
            this.Controls.Add(this.pbUserPic);
            this.Controls.Add(this.gbMemberInfo);
            this.Controls.Add(this.lblSearchSN);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Member_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member_List";
            this.Load += new System.EventHandler(this.Member_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMemberList.ResumeLayout(false);
            this.gbMemberInfo.ResumeLayout(false);
            this.gbMemberInfo.PerformLayout();
            this.gbGuardianInfo.ResumeLayout(false);
            this.gbGuardianInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.ListView MemberListView;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.Label lblSearchSN;
        private Windows.Forms.MaskedTextBox pbUserPic;
        private Windows.Forms.GroupBox gbMemberList;
        private Windows.Forms.GroupBox gbMemberInfo;
        private Windows.Forms.TextBox tbGuardianName;
        private Windows.Forms.TextBox tbGuardianContact;
        private Windows.Forms.TextBox tbYrLvl;
        private Windows.Forms.TextBox tbContactNum;
        private Windows.Forms.TextBox tbName;
        private Windows.Forms.Label lblGuardianContact;
        private Windows.Forms.Label lblGuardianName;
        private Windows.Forms.Label lblYrLvl;
        private Windows.Forms.Label lblContactNum;
        private Windows.Forms.Label lblName;
        private Windows.Forms.Button BackButton;
        private Windows.Forms.ColumnHeader columnHeader1;
        private Windows.Forms.ColumnHeader columnHeader2;
        private Windows.Forms.ColumnHeader columnHeader3;
        private Windows.Forms.OpenFileDialog openFileDialog1;
        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem clearMemberInfoToolStripMenuItem;
        private Windows.Forms.TextBox tbAge;
        private Windows.Forms.Label lblAge;
        private Windows.Forms.ToolStripMenuItem countNewMemberToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem countOldMemberToolStripMenuItem;
        private Windows.Forms.GroupBox gbGuardianInfo;
    }
}