using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MainMenu.Initialize("server=192.168.1.4;uid=root;pwd=;database=coess;sslmode=none;");
            }
        }

        //Image variables
        string pickedImage = "";
        string location = @"C:\\COESS\\Images\\Pubmat\\";
        string fileName = "";

        public static string finalevent;

        public string event_req()
        {
            //event_name,event_date,event_location,event_pubmat
            string event_complete = null;
            event_complete = EnCryptDecrypt.CryptorEngine.Encrypt(event_name.Text, true);
            event_complete = event_complete+"','"+ EnCryptDecrypt.CryptorEngine.Encrypt(Convert.ToString(event_date.Value.ToShortDateString()), true);
            event_complete = event_complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(Convert.ToString(event_location.Text), true);
            event_complete = event_complete + "','" + EnCryptDecrypt.CryptorEngine.Encrypt(location + fileName, true);
            return event_complete;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Insert an Image";
            openFileDialog1.InitialDirectory = location;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|TIFF Images|*.tif|PNG Images|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openFileDialog1.SafeFileName;
                pickedImage = openFileDialog1.FileName;
                event_pubmat.BackgroundImage = Image.FromFile(pickedImage);
                event_pubmat.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Form events = new Events();
                events.Show();
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalevent = event_name.Text;
            finalevent = finalevent.Replace(' ', '_');
            MainMenu.Insert("insert into event_list (event_name,event_date,event_location,event_pubmat) values ('" + event_req()+"');");
            if (MainMenu.isMaster == true)
            {
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
            }
            else
            {
                MainMenu.Initialize("server=192.168.1.4;uid=root;pwd=;database=coess_events;sslmode=none;");
            }
            MainMenu.Insert("create table " +finalevent + " (ID_No int(3) null, FN varchar(255) not null, LN varchar(255) not null, SN varchar(255) not null, Year_Level varchar(255) null, Time_In varchar(255) null, Time_Out varchar(255) null, primary key(SN));");
            File.Copy(pickedImage, @"C:\\COESS\\Images\\Pubmat\\" + fileName);
            event_name.Text = null;
            event_location.Text = null;
            event_date.Value = DateTime.Today;
            event_pubmat.BackgroundImage = System.Properties.Resources.Blank_BG1;
            if (DialogResult.No == MessageBox.Show("Event Created!\n\nWould you like to create another event?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form events = new Events();
                events.Show();
                Close();
            }
        }
    }
}
