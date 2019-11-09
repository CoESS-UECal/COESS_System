namespace System
{
    partial class New_Event
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Event));
            this.event_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.event_location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.event_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.event_pubmat = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.event_pubmat)).BeginInit();
            this.SuspendLayout();
            // 
            // event_name
            // 
            this.event_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.event_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.ForeColor = System.Drawing.Color.White;
            this.event_name.Location = new System.Drawing.Point(196, 65);
            this.event_name.Multiline = true;
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(452, 26);
            this.event_name.TabIndex = 5;
            this.event_name.Enter += new System.EventHandler(this.event_name_Enter);
            this.event_name.Leave += new System.EventHandler(this.event_name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Location:";
            // 
            // event_location
            // 
            this.event_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.event_location.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_location.ForeColor = System.Drawing.Color.White;
            this.event_location.Location = new System.Drawing.Point(231, 119);
            this.event_location.Multiline = true;
            this.event_location.Name = "event_location";
            this.event_location.Size = new System.Drawing.Size(417, 26);
            this.event_location.TabIndex = 7;
            this.event_location.Enter += new System.EventHandler(this.event_location_Enter);
            this.event_location.Leave += new System.EventHandler(this.event_location_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Date:";
            // 
            // event_date
            // 
            this.event_date.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_date.Location = new System.Drawing.Point(185, 181);
            this.event_date.Name = "event_date";
            this.event_date.Size = new System.Drawing.Size(197, 20);
            this.event_date.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::System.Properties.Resources.CREATE_EVENT;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button1.Location = new System.Drawing.Point(175, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 60);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // event_pubmat
            // 
            this.event_pubmat.BackgroundImage = global::System.Properties.Resources.Blank_BG1;
            this.event_pubmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.event_pubmat.Location = new System.Drawing.Point(19, 224);
            this.event_pubmat.Name = "event_pubmat";
            this.event_pubmat.Size = new System.Drawing.Size(629, 263);
            this.event_pubmat.TabIndex = 11;
            this.event_pubmat.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::System.Properties.Resources.image;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button2.Location = new System.Drawing.Point(598, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.button3.Location = new System.Drawing.Point(9, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(250, 250);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // New_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::System.Properties.Resources.NewMemberBackgroundVersion2;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.event_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.event_location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.event_pubmat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Event";
            this.Load += new System.EventHandler(this.New_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_pubmat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox event_name;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label2;
        private Windows.Forms.TextBox event_location;
        private Windows.Forms.Label label3;
        private Windows.Forms.DateTimePicker event_date;
        private Windows.Forms.Button button1;
        private Windows.Forms.PictureBox event_pubmat;
        private Windows.Forms.OpenFileDialog openFileDialog1;
        private Windows.Forms.Button button2;
        private Windows.Forms.Button button3;
        private Windows.Forms.ImageList imageList1;
    }
}