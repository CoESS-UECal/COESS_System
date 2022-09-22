using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class New_Event : Form
    {
        public New_Event()
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
            event_location.Text = "Event Location";
            event_location.ForeColor = SystemColors.GrayText;
            event_name.Text = "Event Name";
            event_name.ForeColor = SystemColors.GrayText;
            lblEnterEventName.Visible = false;
            lblEnterLocation.Visible = false;
        }

        //Color
        Pen red = new Pen(Color.Red);
        System.Drawing.SolidBrush fillRed = new System.Drawing.SolidBrush(Color.Red);
        Rectangle rect_event_name = new Rectangle();
        Rectangle rect_event_location = new Rectangle();
        
        //Image variables
        //string pickedImage = "";
        string location = @"C:\COESS\Images\Pubmat\";
        string fileName = "";
        string file1;
        public static string finalevent;
        bool duplicate=false;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        public void GetEname(string ename)
        {
            int dup = 1;
            string query = "select count(Event_Name) from event_list where Event_name = '" + EnCryptDecrypt.CryptorEngine.Encrypt(ename, true) + "';";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        if (Convert.ToInt32(dataReader[0].ToString()) >= dup)
                        {
                            duplicate = true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MainMenu.CloseConnection();
                }
            }
        }

        public string event_req()
        {
            //event_name,event_date,event_location,event_pubmat
            string event_complete = null;
            event_complete = EnCryptDecrypt.CryptorEngine.Encrypt(event_name.Text, true);
            event_complete = event_complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Convert.ToString(event_date.Value.ToShortDateString()), true);
            event_complete = event_complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Convert.ToString(event_location.Text), true);
            event_complete = event_complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(location + file1, true);
            return event_complete;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mainmenu = new MainMenu();
            mainmenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(event_date.Value.ToShortDateString());
            finalevent = event_name.Text;
            finalevent = finalevent.Replace(' ', '_');
            GetEname(event_name.Text);
            if (!duplicate)
            {
                MainMenu.Insert("insert into event_list (event_name,event_date,event_location,event_pubmat) values ('" + event_req() + "');");
                if (MainMenu.isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess_events;sslmode=none;");
                }
                MainMenu.Insert("create table " + finalevent + " (ID_No int(3) null, FN varchar(255) not null, LN varchar(255) not null, SN varchar(255) not null, Year_Level varchar(255) null, Time_In varchar(255) null, Time_Out varchar(255) null, primary key(SN));");
                File.Copy(fileName, @"C:\COESS\Images\Pubmat\" + file1);
                event_name.Text = null;
                event_location.Text = null;
                event_date.Value = DateTime.Now;
                Image dump = event_pubmat.BackgroundImage;
                if (dump != null)
                    dump.Dispose();
                if (DialogResult.No == MessageBox.Show("Event Created!\n\nWould you like to create another event?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Form mainmenu = new MainMenu();
                    mainmenu.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Event is already in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                event_name.Text = null;
                event_location.Text = null;
                event_date.Value = DateTime.Today;
                Image dump = event_pubmat.BackgroundImage;
                if (dump != null)
                    dump.Dispose();
            }
        }

        private void New_Event_Load(object sender, EventArgs e)
        {
            finalevent = "";
            event_date.MinDate = DateTime.Now;
        }

        private void event_name_Leave(object sender, EventArgs e)
        {
            if (event_name.Text.Length == 0)
            {
                event_name.Text = "Event Name";
                event_name.ForeColor = SystemColors.GrayText;
            }
        }

        private void event_name_Enter(object sender, EventArgs e)
        {
            if (event_name.Text == "Event Name")
            {
                event_name.Text = "";
                event_name.ForeColor = Color.White;
                lblEventName.Visible = true;
            }
        }

        private void event_location_Enter(object sender, EventArgs e)
        {
            if (event_location.Text == "Event Location")
            {
                event_location.Text = "";
                event_location.ForeColor = Color.White;
            }
        }

        private void event_location_Leave(object sender, EventArgs e)
        {
            if (event_location.Text.Length == 0)
            {
                event_location.Text = "Event Location";
                event_location.ForeColor = SystemColors.GrayText;
            }
        }

        private void New_Event_Paint(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
           g.DrawRectangle(red, rect_event_name);
           g.DrawRectangle(red, rect_event_location);
        }

        private void btnEventDetailsNext_Click(object sender, EventArgs e)
        {
            if(event_name.Text != "Event Name" && event_location.Text != "Event Location")
            {
                pnlEventImage.BringToFront();
                button3.Visible = false;
                label1.Visible = true;
            }

            if (event_name.Text == "Event Name")
            {
                event_name.BorderStyle = BorderStyle.None;
                rect_event_name.X = event_name.Location.X - 2;
                rect_event_name.Y = event_name.Location.Y + 49;
                rect_event_name.Height = event_name.Height + 2;
                rect_event_name.Width = event_name.Width + 2;
                lblEnterEventName.ForeColor = Color.FromArgb(249, 69, 69);
                lblEnterEventName.Visible = true;
          
            }
           else if (lblEnterEventName.Visible == true)
            {
                event_name.BorderStyle = BorderStyle.Fixed3D;
                rect_event_name.Height = 0;
                rect_event_name.Width = 0;
                lblEnterEventName.Visible = false;
     
            }

            Invalidate();
            if (event_location.Text == "Event Location") { 
                event_location.BorderStyle = BorderStyle.None;
                rect_event_location.X = event_location.Location.X - 2;
                rect_event_location.Y = event_location.Location.Y + 49;
                rect_event_location.Height = event_location.Height + 2;
                rect_event_location.Width = event_location.Width + 2;
                lblEnterLocation.ForeColor = Color.FromArgb(249, 69, 69);
                lblEnterLocation.Visible = true;

            }
            else if(lblEnterLocation.Visible == true)
            {
                event_location.BorderStyle = BorderStyle.Fixed3D;
                rect_event_location.Height = 0;
                rect_event_location.Width = 0;
                lblEnterLocation.Visible = false;
            }

            Invalidate();
        }

        private void btnEventImageBack_Click(object sender, EventArgs e)
        {
            pnlEventDetails.BringToFront();
            button3.Visible = true;
            label1.Visible = false;
        }

        private void event_pubmat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.Title = "Insert an Image";
            openFileDialog1.InitialDirectory = location;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|TIFF Images|*.tif|PNG Images|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                imageList1.Dispose();
                imageList1.Images.Clear();
                file1 = openFileDialog1.SafeFileName;
                fileName = openFileDialog1.FileName;
                Image pickedImage = Image.FromFile(fileName);
                imageList1.Images.Add(pickedImage);
                event_pubmat.BackgroundImage = imageList1.Images[0];
                event_pubmat.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }

    }

