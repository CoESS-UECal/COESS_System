namespace System
{
    partial class Event_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_List));
            this.gbEventList = new System.Windows.Forms.GroupBox();
            this.EventListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEventInfo = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotalWord = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.gbRegistered = new System.Windows.Forms.GroupBox();
            this.RegisteredListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.tbEventLocation = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.pbPubmat = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbEventList.SuspendLayout();
            this.gbEventInfo.SuspendLayout();
            this.gbRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPubmat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEventList
            // 
            this.gbEventList.BackColor = System.Drawing.Color.Transparent;
            this.gbEventList.Controls.Add(this.EventListView);
            this.gbEventList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEventList.ForeColor = System.Drawing.Color.White;
            this.gbEventList.Location = new System.Drawing.Point(12, 50);
            this.gbEventList.Name = "gbEventList";
            this.gbEventList.Size = new System.Drawing.Size(409, 514);
            this.gbEventList.TabIndex = 12;
            this.gbEventList.TabStop = false;
            this.gbEventList.Text = "Event List";
            // 
            // EventListView
            // 
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.EventListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListView.FullRowSelect = true;
            this.EventListView.HideSelection = false;
            this.EventListView.Location = new System.Drawing.Point(6, 24);
            this.EventListView.MultiSelect = false;
            this.EventListView.Name = "EventListView";
            this.EventListView.Size = new System.Drawing.Size(397, 484);
            this.EventListView.TabIndex = 0;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            this.EventListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EventListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event Name";
            this.columnHeader1.Width = 291;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 98;
            // 
            // gbEventInfo
            // 
            this.gbEventInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbEventInfo.Controls.Add(this.btnReset);
            this.gbEventInfo.Controls.Add(this.lblCount);
            this.gbEventInfo.Controls.Add(this.lblTotalWord);
            this.gbEventInfo.Controls.Add(this.cbTime);
            this.gbEventInfo.Controls.Add(this.gbRegistered);
            this.gbEventInfo.Controls.Add(this.btnRemove);
            this.gbEventInfo.Controls.Add(this.btnRegistration);
            this.gbEventInfo.Controls.Add(this.tbEventLocation);
            this.gbEventInfo.Controls.Add(this.tbEventName);
            this.gbEventInfo.Controls.Add(this.lblEventLocation);
            this.gbEventInfo.Controls.Add(this.lblEventName);
            this.gbEventInfo.Controls.Add(this.pbPubmat);
            this.gbEventInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEventInfo.ForeColor = System.Drawing.Color.White;
            this.gbEventInfo.Location = new System.Drawing.Point(427, 50);
            this.gbEventInfo.Name = "gbEventInfo";
            this.gbEventInfo.Size = new System.Drawing.Size(585, 514);
            this.gbEventInfo.TabIndex = 13;
            this.gbEventInfo.TabStop = false;
            this.gbEventInfo.Text = "Event Information";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(430, 435);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 37);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "RESET FIELDS";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(515, 411);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 21);
            this.lblCount.TabIndex = 28;
            this.lblCount.Text = "0";
            // 
            // lblTotalWord
            // 
            this.lblTotalWord.AutoSize = true;
            this.lblTotalWord.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalWord.ForeColor = System.Drawing.Color.White;
            this.lblTotalWord.Location = new System.Drawing.Point(428, 411);
            this.lblTotalWord.Name = "lblTotalWord";
            this.lblTotalWord.Size = new System.Drawing.Size(52, 21);
            this.lblTotalWord.TabIndex = 27;
            this.lblTotalWord.Text = "Total:";
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.BackColor = System.Drawing.Color.Transparent;
            this.cbTime.Checked = true;
            this.cbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbTime.ForeColor = System.Drawing.Color.White;
            this.cbTime.Location = new System.Drawing.Point(430, 326);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(86, 25);
            this.cbTime.TabIndex = 26;
            this.cbTime.Text = "Time In";
            this.cbTime.UseVisualStyleBackColor = false;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // gbRegistered
            // 
            this.gbRegistered.BackColor = System.Drawing.Color.Transparent;
            this.gbRegistered.Controls.Add(this.RegisteredListView);
            this.gbRegistered.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistered.ForeColor = System.Drawing.Color.White;
            this.gbRegistered.Location = new System.Drawing.Point(6, 265);
            this.gbRegistered.Name = "gbRegistered";
            this.gbRegistered.Size = new System.Drawing.Size(416, 243);
            this.gbRegistered.TabIndex = 23;
            this.gbRegistered.TabStop = false;
            this.gbRegistered.Text = "Registered";
            // 
            // RegisteredListView
            // 
            this.RegisteredListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.RegisteredListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisteredListView.FullRowSelect = true;
            this.RegisteredListView.HideSelection = false;
            this.RegisteredListView.Location = new System.Drawing.Point(8, 18);
            this.RegisteredListView.Name = "RegisteredListView";
            this.RegisteredListView.Size = new System.Drawing.Size(401, 219);
            this.RegisteredListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RegisteredListView.TabIndex = 1;
            this.RegisteredListView.UseCompatibleStateImageBehavior = false;
            this.RegisteredListView.View = System.Windows.Forms.View.Details;
            this.RegisteredListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.RegisteredListView_ColumnClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "First Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Student No";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time In";
            this.columnHeader8.Width = 73;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Time Out";
            this.columnHeader9.Width = 82;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(428, 361);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 37);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistration.Location = new System.Drawing.Point(428, 283);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(149, 37);
            this.btnRegistration.TabIndex = 21;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // tbEventLocation
            // 
            this.tbEventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbEventLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEventLocation.ForeColor = System.Drawing.Color.White;
            this.tbEventLocation.Location = new System.Drawing.Point(86, 225);
            this.tbEventLocation.Name = "tbEventLocation";
            this.tbEventLocation.ReadOnly = true;
            this.tbEventLocation.Size = new System.Drawing.Size(491, 29);
            this.tbEventLocation.TabIndex = 20;
            // 
            // tbEventName
            // 
            this.tbEventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbEventName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEventName.ForeColor = System.Drawing.Color.White;
            this.tbEventName.Location = new System.Drawing.Point(86, 185);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.ReadOnly = true;
            this.tbEventName.Size = new System.Drawing.Size(491, 29);
            this.tbEventName.TabIndex = 19;
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblEventLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblEventLocation.Location = new System.Drawing.Point(6, 228);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(80, 21);
            this.lblEventLocation.TabIndex = 14;
            this.lblEventLocation.Text = "Location:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEventName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(6, 188);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(60, 21);
            this.lblEventName.TabIndex = 13;
            this.lblEventName.Text = "Name:";
            // 
            // pbPubmat
            // 
            this.pbPubmat.BackgroundImage = global::System.Properties.Resources.Blank_BG1;
            this.pbPubmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPubmat.Location = new System.Drawing.Point(10, 19);
            this.pbPubmat.Name = "pbPubmat";
            this.pbPubmat.Size = new System.Drawing.Size(567, 150);
            this.pbPubmat.TabIndex = 1;
            this.pbPubmat.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::System.Properties.Resources.BACK;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btnExit.Location = new System.Drawing.Point(9, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 32;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Event_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::System.Properties.Resources.NewMemberBackgroundVersion2;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbEventInfo);
            this.Controls.Add(this.gbEventList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event_List";
            this.Load += new System.EventHandler(this.Event_List_Load);
            this.gbEventList.ResumeLayout(false);
            this.gbEventInfo.ResumeLayout(false);
            this.gbEventInfo.PerformLayout();
            this.gbRegistered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPubmat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.GroupBox gbEventList;
        private Windows.Forms.ListView EventListView;
        private Windows.Forms.GroupBox gbEventInfo;
        private Windows.Forms.TextBox tbEventLocation;
        private Windows.Forms.Label lblEventLocation;
        private Windows.Forms.Label lblEventName;
        private Windows.Forms.PictureBox pbPubmat;
        private Windows.Forms.GroupBox gbRegistered;
        private Windows.Forms.Button btnRemove;
        private Windows.Forms.Button btnRegistration;
        private Windows.Forms.Button btnExit;
        private Windows.Forms.ColumnHeader columnHeader1;
        private Windows.Forms.ColumnHeader columnHeader2;
        private Windows.Forms.ColumnHeader columnHeader4;
        private Windows.Forms.ColumnHeader columnHeader5;
        public Windows.Forms.ListView RegisteredListView;
        private Windows.Forms.ColumnHeader columnHeader6;
        private Windows.Forms.ColumnHeader columnHeader7;
        private Windows.Forms.ColumnHeader columnHeader8;
        private Windows.Forms.ColumnHeader columnHeader9;
        private Windows.Forms.TextBox tbEventName;
        public Windows.Forms.CheckBox cbTime;
        private Windows.Forms.Label lblCount;
        private Windows.Forms.Label lblTotalWord;
        private Windows.Forms.Button btnReset;
    }
}