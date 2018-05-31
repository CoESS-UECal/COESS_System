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
    public partial class Member_List : Form
    {
        public Member_List()
        {
            InitializeComponent();
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
        }
        public static string  fullname, lastname,firstname, mi, idnumber;


        public void Populate_ListView(string myquery)
        {
            listView1.Items.Clear();
            ListViewItem iItem;
            string query = myquery;
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        iItem = new ListViewItem(dataReader[0].ToString());
                        iItem.SubItems.Add(dataReader[1].ToString());
                        fullname = dataReader[2].ToString() + " " + dataReader[3].ToString();
                        iItem.SubItems.Add(fullname);
                        listView1.Items.Add(iItem);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MainMenu.CloseConnection();
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        public  static void Updated(string col, string data, string ID) //col = column to be edited, data = member info changed, ID = member ID number
        {
            string query = "UPDATE member_list SET " + col + " = '"+ data  +"' WHERE ID_No = " + ID + ";";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    cmd.ExecuteNonQuery();
             
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
        public void LMI(string ID) // LMI = Load Member Info
        {
            string query = "Select * from member_list where ID_NO = '" + ID + "'";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lastname = reader.GetString("LN");
                        firstname = reader.GetString("FN");
                        mi = reader.GetString("MI");
                        textBox1.Text = reader.GetString("FN") + " " + reader.GetString("MI") + " " + reader.GetString("LN");
                        textBox2.Text = reader.GetString("Address");
                        textBox3.Text = reader.GetString("Contact_No");
                        textBox4.Text = reader.GetString("Year_Level");
                        textBox5.Text = reader.GetString("Guard_Name");
                        textBox6.Text = reader.GetString("Guard_Contact");
                        pictureBox1.ImageLocation = reader.GetString("ID_Address");
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to go back?\n\nAll information will be discarded.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form members = new Members();
                members.Show();
                Close();
            }
        }

        private void Member_List_Load(object sender, EventArgs e)
        {
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox2.Text;
            GeneralEdit.col = "Address";
             Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox2.Text = GeneralEdit.data;
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox3.Text;
            GeneralEdit.col = "Contact_No";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox3.Text = GeneralEdit.data;
        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox4.Text;
            GeneralEdit.col = "Year_Level";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox4.Text = GeneralEdit.data;
        }
//TESTING dsfjfajkgdksahjfjasjkfgdkfj
        private void textBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox5.Text;
            GeneralEdit.col = "Guard_Name";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox5.Text = GeneralEdit.data;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form form1 = new NameEdit();
            form1.ShowDialog();
            textBox1.Text = fullname;
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void textBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox6.Text;
            GeneralEdit.col = "Guard_Contact";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox6.Text = GeneralEdit.data;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                idnumber = item.SubItems[0].Text;
                LMI(item.SubItems[0].Text);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            Populate_ListView("select ID_No,SN,FN,LN from member_list where SN like '"+maskedTextBox1.Text+"%'");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            string location = @"C:\\COESS\\Images\\";
            string filename = "";
            string pickedImage = "";
           openFileDialog1.Title = "Insert an Image";
            openFileDialog1.InitialDirectory = location;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|TIFF Images|*.tif|PNG Images|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string oldimage = pictureBox1.ImageLocation;
                filename = openFileDialog1.SafeFileName;
              pickedImage = openFileDialog1.FileName;
                pictureBox1.ImageLocation = pickedImage;
                if (DialogResult.Yes == MessageBox.Show("Would you like to save changes?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Updated("ID_Address", location + filename, idnumber);
                }
               else
                {
                    pictureBox1.ImageLocation = oldimage;
                }
            }
        }
    }
}
