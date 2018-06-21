using System;
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
    public partial class Event_List : Form
    {
        public Event_List()
        {
            InitializeComponent();
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");

        }
        public static string event_name;
        string SN;
        public static bool istimein=false;
        public void LEI(string ID) // LMI = Load Event Info
        {
            string query = "Select Event_Name, Event_Location, Event_Pubmat from event_list where Event_Name = '" +EnCryptDecrypt.CryptorEngine.Encrypt(ID,true) + "'";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader[0].ToString(),true);
                        textBox2.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader[1].ToString(), true);
                        pictureBox1.ImageLocation = EnCryptDecrypt.CryptorEngine.Decrypt(reader[2].ToString(), true);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
        
            public void LA(string event_name) // LA=Load Attendees
            {
                string query = "Select FN, LN, SN, ID_No, Time_In, Time_Out from " + event_name + ";";
                listView2.Items.Clear();
                ListViewItem iItem;
                if (MainMenu.OpenConnection())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[0].ToString(),true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(),true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[2].ToString(),true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[3].ToString(),true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[4].ToString(),true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[5].ToString(),true));
                            listView2.Items.Add(iItem);
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
                    listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
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
                        iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[0].ToString(),true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(),true));
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Form registration = new Registration(this);
            registration.Show();

            Form reg_noid = new Registration_NoID(this);
            reg_noid.Show();
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

        private void Event_List_Load(object sender, EventArgs e)
        {
            Populate_ListView("select Event_Name,Event_Date from event_list;");

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                event_name = item.SubItems[0].Text;
                event_name = event_name.Replace(' ', '_');
                LEI(item.SubItems[0].Text);
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;");
                LA(event_name);
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                istimein = true;
            }
            else
            {
                istimein = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//remove button
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                SN =item.SubItems[2].Text;
                MainMenu.Initialize("server=localhost;uid=coess;pwd=uecalcpe2018;database=coess_events;");
                MainMenu.Insert("delete from " +event_name + "' where SN = '" + EnCryptDecrypt.CryptorEngine.Encrypt(SN,true) + "';");
                listView2.Items.Remove(item);
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");

            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
