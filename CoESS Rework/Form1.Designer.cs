namespace MAUEK_System
{
    partial class MainMenu
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
            this.NavBar = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.EventListButton = new System.Windows.Forms.Button();
            this.EventRegButton = new System.Windows.Forms.Button();
            this.Marker = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeScreen = new System.Windows.Forms.Panel();
            this.EventList = new System.Windows.Forms.Panel();
            this.EventReg = new System.Windows.Forms.Panel();
            this.Print = new System.Windows.Forms.Panel();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.EventRegTimer = new System.Windows.Forms.Timer(this.components);
            this.EventListTimer = new System.Windows.Forms.Timer(this.components);
            this.PrintTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NavBar.Controls.Add(this.ExitButton);
            this.NavBar.Controls.Add(this.PrintButton);
            this.NavBar.Controls.Add(this.EventListButton);
            this.NavBar.Controls.Add(this.EventRegButton);
            this.NavBar.Controls.Add(this.Marker);
            this.NavBar.Controls.Add(this.HomeButton);
            this.NavBar.Controls.Add(this.pictureBox1);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(150, 648);
            this.NavBar.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(0, 584);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 64);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(12, 476);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(138, 112);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "PRINT";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // EventListButton
            // 
            this.EventListButton.FlatAppearance.BorderSize = 0;
            this.EventListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventListButton.Location = new System.Drawing.Point(12, 366);
            this.EventListButton.Name = "EventListButton";
            this.EventListButton.Size = new System.Drawing.Size(138, 112);
            this.EventListButton.TabIndex = 4;
            this.EventListButton.Text = "Event List";
            this.EventListButton.UseVisualStyleBackColor = true;
            this.EventListButton.Click += new System.EventHandler(this.EventListButton_Click);
            // 
            // EventRegButton
            // 
            this.EventRegButton.FlatAppearance.BorderSize = 0;
            this.EventRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventRegButton.Location = new System.Drawing.Point(12, 256);
            this.EventRegButton.Name = "EventRegButton";
            this.EventRegButton.Size = new System.Drawing.Size(138, 112);
            this.EventRegButton.TabIndex = 3;
            this.EventRegButton.Text = "EVENT REGISTRATION";
            this.EventRegButton.UseVisualStyleBackColor = true;
            this.EventRegButton.Click += new System.EventHandler(this.EventRegButton_Click);
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.DarkRed;
            this.Marker.Location = new System.Drawing.Point(0, 146);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(10, 112);
            this.Marker.TabIndex = 2;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(12, 146);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(138, 112);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MAUEK_System.Properties.Resources.LogoPlaceHOlder;
            this.pictureBox1.Location = new System.Drawing.Point(0, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeScreen
            // 
            this.HomeScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomeScreen.Location = new System.Drawing.Point(150, 0);
            this.HomeScreen.MaximumSize = new System.Drawing.Size(1002, 648);
            this.HomeScreen.MinimumSize = new System.Drawing.Size(0, 648);
            this.HomeScreen.Name = "HomeScreen";
            this.HomeScreen.Size = new System.Drawing.Size(1002, 648);
            this.HomeScreen.TabIndex = 1;
            // 
            // EventList
            // 
            this.EventList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventList.Location = new System.Drawing.Point(150, 0);
            this.EventList.MaximumSize = new System.Drawing.Size(1002, 648);
            this.EventList.MinimumSize = new System.Drawing.Size(0, 648);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(1002, 648);
            this.EventList.TabIndex = 2;
            // 
            // EventReg
            // 
            this.EventReg.BackColor = System.Drawing.Color.Brown;
            this.EventReg.Location = new System.Drawing.Point(150, 0);
            this.EventReg.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.EventReg.MaximumSize = new System.Drawing.Size(1002, 648);
            this.EventReg.MinimumSize = new System.Drawing.Size(0, 648);
            this.EventReg.Name = "EventReg";
            this.EventReg.Size = new System.Drawing.Size(1002, 648);
            this.EventReg.TabIndex = 3;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Print.Location = new System.Drawing.Point(150, 0);
            this.Print.MaximumSize = new System.Drawing.Size(1002, 648);
            this.Print.MinimumSize = new System.Drawing.Size(0, 648);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(1002, 648);
            this.Print.TabIndex = 4;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 1;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // EventRegTimer
            // 
            this.EventRegTimer.Interval = 1;
            this.EventRegTimer.Tick += new System.EventHandler(this.EventRegTimer_Tick);
            // 
            // EventListTimer
            // 
            this.EventListTimer.Interval = 1;
            this.EventListTimer.Tick += new System.EventHandler(this.EventListTimer_Tick);
            // 
            // PrintTimer
            // 
            this.PrintTimer.Interval = 1;
            this.PrintTimer.Tick += new System.EventHandler(this.PrintTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.HomeScreen);
            this.Controls.Add(this.EventList);
            this.Controls.Add(this.EventReg);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel HomeScreen;
        private System.Windows.Forms.Panel EventList;
        private System.Windows.Forms.Panel EventReg;
        private System.Windows.Forms.Panel Print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel Marker;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button EventListButton;
        private System.Windows.Forms.Button EventRegButton;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Timer EventRegTimer;
        private System.Windows.Forms.Timer EventListTimer;
        private System.Windows.Forms.Timer PrintTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

