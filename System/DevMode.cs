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
    public partial class DevMode : Form
    {
        public DevMode()
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
        }
        public static string fullname, lastname,firstname, mi, idnumber;
        public static string decode(string thisDecode)
        {
            return EnCryptDecrypt.CryptorEngine.Decrypt(thisDecode,true);
        }

        public static string encode(string thisEncode)
        {
            if (null == thisEncode)
                return string.Empty;

            return EnCryptDecrypt.CryptorEngine.Encrypt(thisEncode,true);
        }


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
                        iItem.SubItems.Add(decode(dataReader[1].ToString()));
                        fullname = decode(dataReader[2].ToString()) + " " + decode(dataReader[3].ToString());
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
            string query = "UPDATE member_list SET " + col + " = '"+ EnCryptDecrypt.CryptorEngine.Encrypt(data,true)  +"' WHERE ID_No = " + ID + ";";
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
                        Member_List.lastname = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("LN"),true);
                        Member_List.firstname = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("FN"),true);
                        Member_List.mi = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("MI"),true);
                        textBox1.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("FN"),true) + " " + EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("MI"),true) + " " + EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("LN"),true);
                        textBox2.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Address"),true);
                        textBox3.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Contact_No"),true);
                        textBox4.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Year_Level"),true);
                        textBox5.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Guard_Name"),true);
                        textBox6.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Guard_Contact"),true);
                        textBox7.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Age"), true);
                        textBox8.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("SN"), true);
                        textBox9.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Comm"), true);
                        textBox10.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Membership"), true);
                        textBox11.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("BDay"), true);
                        Image dump = pictureBox1.BackgroundImage;
                        if (dump != null)
                            dump.Dispose();
                        pictureBox1.BackgroundImage =Image.FromFile(EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("ID_Address"),true));
                        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                        
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

        public void countnew() //count new member
        {
            string query = "Select count(membership) from member_list where Membership = '4tiIy8LrFw/HLmgSreMHiw=='";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString() + " new members.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void countold() //count old member
        {
           
            string query = "Select count(membership) from member_list where Membership = '0oJH9mE2Sm4=';";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString() + " old members.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Form members = new Members();
                members.Show();
                Close();
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
            textBox1.Text = Member_List.fullname;
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void clearMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            Image dump = pictureBox1.BackgroundImage;
            if (dump != null)
                dump.Dispose();
            pictureBox1.BackgroundImage = Properties.Resources.full_logo_transparent___clear_c;
        }

        private void countNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countnew();
        }

        private void countOldMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countold();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.Sort();
        }


        private void textBox11_DoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox11.Text;
            GeneralEdit.col = "BDay";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox11.Text = GeneralEdit.data;
        }

        private void textBox10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox10.Text;
            GeneralEdit.col = "Membership";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox10.Text = GeneralEdit.data;
        }

        private void textBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox7.Text;
            GeneralEdit.col = "Age";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox7.Text = GeneralEdit.data;
        }

        private void textBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox8.Text;
            GeneralEdit.col = "SN";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox8.Text = GeneralEdit.data;
        }

        private void textBox9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = textBox9.Text;
            GeneralEdit.col = "Comm";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            textBox9.Text = GeneralEdit.data;
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
                Member_List.idnumber = item.SubItems[0].Text;
                LMI(item.SubItems[0].Text);
                
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == null)
            {
                Populate_ListView("select ID_No,SN,FN,LN from member_list;");
            }
            else
            {
                Populate_ListView("select ID_No,SN,FN,LN from member_list where SN like '" + EnCryptDecrypt.CryptorEngine.Encrypt(maskedTextBox1.Text, true) + "%'");
                listView1.Refresh();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            string location = @"C:\COESS\Images\Member\";
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
                //pictureBox1.ImageLocation = pickedImage;
                pictureBox1.BackgroundImage =Image.FromFile(location + filename);
                if (DialogResult.Yes == MessageBox.Show("Would you like to save changes?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Updated("ID_Address", location + filename, idnumber);
                }
                else
                {
                    // pictureBox1.ImageLocation = oldimage;
                    pictureBox1.BackgroundImage = Image.FromFile(oldimage);
                }
            }
        }
    }
}
