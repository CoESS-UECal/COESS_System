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
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
        }
        //Image variables
        string pickedImage = "";
        string location = @"C:\\COESS\\Events\\";
        string fileName = "";
        private void label4_Click(object sender, EventArgs e)
        {

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
                File.Copy(pickedImage, @"C:\\COESS\\Events\\"+fileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to go back?\n\nAll information will be discarded.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form events = new Events();
                events.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu.Insert("insert into event_list (event_name,event_date,event_location,event_pubmat) values ('" + event_name.Text + "','" + Convert.ToString(event_date.Value.ToShortDateString()) + "','" + event_location.Text + "','" +location+fileName+"');");
            event_name.Text = null;
            event_location.Text = null;
            event_date.Value = DateTime.Today;
            event_pubmat.BackgroundImage = System.Properties.Resources.Blank_BG1;
            if (DialogResult.Yes == MessageBox.Show("Would you like to create another event?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form events = new Events();
                events.Show();
                Close();
            }
        }
    }
}
