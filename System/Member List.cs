using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class Member_List : Form
    {
        public static string fullname, lastname, firstname, mi, idnumber;

        public Member_List()
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

        public static string decode(string thisDecode)
        {
            return EnCryptDecrypt.CryptorEngine.Decrypt(thisDecode, true);
        }

        public static string encode(string thisEncode)
        {
            if (null == thisEncode)
                return string.Empty;

            return EnCryptDecrypt.CryptorEngine.Encrypt(thisEncode, true);
        }

        public void Populate_ListView(string myquery)
        {
            MemberListView.Items.Clear();
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
                        MemberListView.Items.Add(iItem);
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
                MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        public static void Updated(string col, string data, string ID) //col = column to be edited, data = member info changed, ID = member ID number
        {
            string query = "UPDATE member_list SET " + col + " = '" + EnCryptDecrypt.CryptorEngine.Encrypt(data, true) + "' WHERE ID_No = " + ID + ";";
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
                        lastname = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("LN"), true);
                        firstname = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("FN"), true);
                        mi = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("MI"), true);
                        tbName.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("FN"), true) + " " + EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("MI"), true) + " " + EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("LN"), true);
                        tbContactNum.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Contact_No"), true);
                        tbYrLvl.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Year_Level"), true);
                        tbGuardianContact.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Guard_Name"), true);
                        tbGuardianName.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Guard_Contact"), true);
                        tbAge.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("Age"), true);
                        Image dump = pictureBox1.BackgroundImage;
                        if (dump != null)
                            dump.Dispose();
                        pictureBox1.BackgroundImage = Image.FromFile(EnCryptDecrypt.CryptorEngine.Decrypt(reader.GetString("ID_Address"), true));
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form mainmenu = new MainMenu();
            mainmenu.Show();
            Close();
        }

        private void Member_List_Load(object sender, EventArgs e)
        {
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void tbContactNum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = tbContactNum.Text;
            GeneralEdit.col = "Contact_No";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            tbContactNum.Text = GeneralEdit.data;
        }

        private void tbYrLvl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = tbYrLvl.Text;
            GeneralEdit.col = "Year_Level";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            tbYrLvl.Text = GeneralEdit.data;
        }

        private void tbGuardianContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = tbGuardianContact.Text;
            GeneralEdit.col = "Guard_Name";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            tbGuardianContact.Text = GeneralEdit.data;
        }

        private void tbName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form form1 = new NameEdit();
            form1.ShowDialog();
            tbName.Text = fullname;
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Populate_ListView("select ID_No,SN,FN,LN from member_list;");
        }

        private void clearMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbName.Text = null;
            tbContactNum.Text = null;
            tbYrLvl.Text = null;
            tbGuardianContact.Text = null;
            tbAge = null;
            tbGuardianName.Text = null;
            Image dump = pictureBox1.BackgroundImage;
            if (dump != null)
                dump.Dispose();
            pictureBox1.BackgroundImage = Properties.Resources.full_logo_transparent_clear_c;
        }

        private void countNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countnew();
        }

        private void countOldMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countold();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MemberListView.Sort();
        }

        private void tbGuardianName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GeneralEdit.data = tbGuardianName.Text;
            GeneralEdit.col = "Guard_Contact";
            Form form1 = new GeneralEdit();
            form1.ShowDialog();
            tbGuardianName.Text = GeneralEdit.data;
        }

        private void MemberListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in MemberListView.SelectedItems)
            {
                idnumber = item.SubItems[0].Text;
                LMI(item.SubItems[0].Text);
            }
        }

        private void mtbSearchSN_TextChanged(object sender, EventArgs e)
        {
            if (pbUserPic.Text == null)
            {
                Populate_ListView("select ID_No,SN,FN,LN from member_list;");
            }
            else
            {
                Populate_ListView("select ID_No,SN,FN,LN from member_list where SN like '" + EnCryptDecrypt.CryptorEngine.Encrypt(pbUserPic.Text, true) + "%'");
                MemberListView.Refresh();
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
                pictureBox1.BackgroundImage = Image.FromFile(pickedImage);
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
