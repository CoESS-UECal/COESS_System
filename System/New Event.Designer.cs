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
            this.event_location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.event_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.event_pubmat = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlEventDetails = new System.Windows.Forms.Panel();
            this.lblEnterEventName = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEnterLocation = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEventDetailsNext = new System.Windows.Forms.Button();
            this.event_name = new System.Windows.Forms.TextBox();
            this.pnlEventImage = new System.Windows.Forms.Panel();
            this.btnEventImageBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.event_pubmat)).BeginInit();
            this.pnlEventDetails.SuspendLayout();
            this.pnlEventImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // event_location
            // 
            this.event_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.event_location.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_location.ForeColor = System.Drawing.Color.White;
            this.event_location.Location = new System.Drawing.Point(20, 196);
            this.event_location.Name = "event_location";
            this.event_location.Size = new System.Drawing.Size(472, 39);
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
            this.label3.Location = new System.Drawing.Point(26, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Date:";
            // 
            // event_date
            // 
            this.event_date.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.event_date.Location = new System.Drawing.Point(23, 307);
            this.event_date.Name = "event_date";
            this.event_date.Size = new System.Drawing.Size(273, 29);
            this.event_date.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(292, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "CREATE EVENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // event_pubmat
            // 
            this.event_pubmat.BackColor = System.Drawing.Color.DimGray;
            this.event_pubmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.event_pubmat.Location = new System.Drawing.Point(17, 52);
            this.event_pubmat.Name = "event_pubmat";
            this.event_pubmat.Size = new System.Drawing.Size(478, 307);
            this.event_pubmat.TabIndex = 11;
            this.event_pubmat.TabStop = false;
            this.event_pubmat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.event_pubmat_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // pnlEventDetails
            // 
            this.pnlEventDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlEventDetails.Controls.Add(this.lblEnterEventName);
            this.pnlEventDetails.Controls.Add(this.lblEventName);
            this.pnlEventDetails.Controls.Add(this.lblEnterLocation);
            this.pnlEventDetails.Controls.Add(this.lblEventLocation);
            this.pnlEventDetails.Controls.Add(this.label4);
            this.pnlEventDetails.Controls.Add(this.btnEventDetailsNext);
            this.pnlEventDetails.Controls.Add(this.event_location);
            this.pnlEventDetails.Controls.Add(this.event_date);
            this.pnlEventDetails.Controls.Add(this.label3);
            this.pnlEventDetails.Controls.Add(this.event_name);
            this.pnlEventDetails.Location = new System.Drawing.Point(0, 50);
            this.pnlEventDetails.Name = "pnlEventDetails";
            this.pnlEventDetails.Size = new System.Drawing.Size(512, 470);
            this.pnlEventDetails.TabIndex = 32;
            // 
            // lblEnterEventName
            // 
            this.lblEnterEventName.AutoSize = true;
            this.lblEnterEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEventName.ForeColor = System.Drawing.Color.White;
            this.lblEnterEventName.Location = new System.Drawing.Point(29, 135);
            this.lblEnterEventName.Name = "lblEnterEventName";
            this.lblEnterEventName.Size = new System.Drawing.Size(213, 20);
            this.lblEnterEventName.TabIndex = 37;
            this.lblEnterEventName.Text = "Please Enter an Event Name";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(26, 52);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(171, 37);
            this.lblEventName.TabIndex = 36;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEnterLocation
            // 
            this.lblEnterLocation.AutoSize = true;
            this.lblEnterLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLocation.ForeColor = System.Drawing.Color.White;
            this.lblEnterLocation.Location = new System.Drawing.Point(29, 238);
            this.lblEnterLocation.Name = "lblEnterLocation";
            this.lblEnterLocation.Size = new System.Drawing.Size(192, 20);
            this.lblEnterLocation.TabIndex = 39;
            this.lblEnterLocation.Text = "Please Enter the Location";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblEventLocation.Location = new System.Drawing.Point(26, 153);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(206, 37);
            this.lblEventLocation.TabIndex = 38;
            this.lblEventLocation.Text = "Event Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "Event Details";
            // 
            // btnEventDetailsNext
            // 
            this.btnEventDetailsNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.btnEventDetailsNext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEventDetailsNext.ForeColor = System.Drawing.Color.White;
            this.btnEventDetailsNext.Location = new System.Drawing.Point(156, 373);
            this.btnEventDetailsNext.Name = "btnEventDetailsNext";
            this.btnEventDetailsNext.Size = new System.Drawing.Size(200, 60);
            this.btnEventDetailsNext.TabIndex = 34;
            this.btnEventDetailsNext.Text = "NEXT";
            this.btnEventDetailsNext.UseVisualStyleBackColor = false;
            this.btnEventDetailsNext.Click += new System.EventHandler(this.btnEventDetailsNext_Click);
            // 
            // event_name
            // 
            this.event_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.event_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.ForeColor = System.Drawing.Color.White;
            this.event_name.Location = new System.Drawing.Point(20, 93);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(472, 39);
            this.event_name.TabIndex = 5;
            this.event_name.Enter += new System.EventHandler(this.event_name_Enter);
            this.event_name.Leave += new System.EventHandler(this.event_name_Leave);
            // 
            // pnlEventImage
            // 
            this.pnlEventImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlEventImage.Controls.Add(this.btnEventImageBack);
            this.pnlEventImage.Controls.Add(this.label1);
            this.pnlEventImage.Controls.Add(this.button1);
            this.pnlEventImage.Controls.Add(this.event_pubmat);
            this.pnlEventImage.Location = new System.Drawing.Point(0, 50);
            this.pnlEventImage.Name = "pnlEventImage";
            this.pnlEventImage.Size = new System.Drawing.Size(512, 470);
            this.pnlEventImage.TabIndex = 33;
            // 
            // btnEventImageBack
            // 
            this.btnEventImageBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(219)))));
            this.btnEventImageBack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnEventImageBack.ForeColor = System.Drawing.Color.White;
            this.btnEventImageBack.Location = new System.Drawing.Point(17, 384);
            this.btnEventImageBack.Name = "btnEventImageBack";
            this.btnEventImageBack.Size = new System.Drawing.Size(200, 60);
            this.btnEventImageBack.TabIndex = 37;
            this.btnEventImageBack.Text = "BACK";
            this.btnEventImageBack.UseVisualStyleBackColor = false;
            this.btnEventImageBack.Click += new System.EventHandler(this.btnEventImageBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Event Pubmat";
            this.label1.Visible = false;
            // 
            // New_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::System.Properties.Resources.NEW_EVENT_BACKGROUND;
            this.ClientSize = new System.Drawing.Size(512, 576);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlEventImage);
            this.Controls.Add(this.pnlEventDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Event";
            this.Load += new System.EventHandler(this.New_Event_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.New_Event_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.event_pubmat)).EndInit();
            this.pnlEventDetails.ResumeLayout(false);
            this.pnlEventDetails.PerformLayout();
            this.pnlEventImage.ResumeLayout(false);
            this.pnlEventImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Windows.Forms.TextBox event_location;
        private Windows.Forms.Label label3;
        private Windows.Forms.DateTimePicker event_date;
        private Windows.Forms.Button button1;
        private Windows.Forms.PictureBox event_pubmat;
        private Windows.Forms.OpenFileDialog openFileDialog1;
        private Windows.Forms.Button button3;
        private Windows.Forms.ImageList imageList1;
        private Windows.Forms.Panel pnlEventDetails;
        private Windows.Forms.Label label4;
        private Windows.Forms.Button btnEventDetailsNext;
        private Windows.Forms.Panel pnlEventImage;
        private Windows.Forms.Button btnEventImageBack;
        private Windows.Forms.Label lblEnterEventName;
        private Windows.Forms.Label lblEnterLocation;
        private Windows.Forms.TextBox event_name;
        private Windows.Forms.Label lblEventName;
        private Windows.Forms.Label lblEventLocation;
        private Windows.Forms.Label label1;
    }
}