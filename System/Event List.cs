using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class Event_List : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public static string event_name;
        string SN;
        public static bool istimein = false;

        public Event_List()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.RegisteredListView.ListViewItemSorter = lvwColumnSorter;

            if (MainMenu.isMaster == true)
            {
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
            }
            else
            {
                MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
            }
        }

        public void LEI(string ID) // LEI = Load Event Info
        {
            string query = "Select Event_Name, Event_Location, Event_Pubmat from event_list where Event_Name = '" + EnCryptDecrypt.CryptorEngine.Encrypt(ID, true) + "'";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        tbEventName.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader[0].ToString(), true);
                        tbEventLocation.Text = EnCryptDecrypt.CryptorEngine.Decrypt(reader[1].ToString(), true);
                        Image dump = pbPubmat.BackgroundImage;
                        if (dump != null)
                            dump.Dispose();
                        pbPubmat.BackgroundImage = Image.FromFile(EnCryptDecrypt.CryptorEngine.Decrypt(reader[2].ToString(), true));
                        pbPubmat.BackgroundImageLayout = ImageLayout.Stretch;
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
            if (event_name == null)
            {
                MessageBox.Show("No Event Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "Select FN, LN, SN, ID_No, Time_In, Time_Out from " + event_name + ";";
                RegisteredListView.Items.Clear();
                ListViewItem iItem;
                if (MainMenu.OpenConnection())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[0].ToString(), true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(), true));
                            iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[2].ToString(), true));
                            iItem.SubItems.Add(dataReader[3].ToString());
                            iItem.SubItems.Add(dataReader[4].ToString());
                            iItem.SubItems.Add(dataReader[5].ToString());
                            RegisteredListView.Items.Add(iItem);
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
                    RegisteredListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    RegisteredListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lblCount.Text = RegisteredListView.Items.Count.ToString();
                    if (RegisteredListView.Items.Count == 0)
                    {

                    }
                    else
                    {
                        RegisteredListView.Items[RegisteredListView.Items.Count - 1].EnsureVisible();
                    }
                }
            }
        }

        public void Populate_ListView(string myquery)
        {
            EventListView.Items.Clear();
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
                        iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[0].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(), true));
                        EventListView.Items.Add(iItem);

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
                EventListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                EventListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Form reg_noid = new Registration_NoID(this);
            Form registration = new Registration(this);
            registration.Show();
            reg_noid.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form mainmenu = new MainMenu();
            mainmenu.Show();
            Close();
        }

        private void Event_List_Load(object sender, EventArgs e)
        {
            Populate_ListView("select Event_Name,Event_Date from event_list;");
        }

        private void EventListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in EventListView.SelectedItems)
            {
                event_name = item.SubItems[0].Text;
                event_name = event_name.Replace(' ', '_');
                LEI(item.SubItems[0].Text);
                if (MainMenu.isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess_events;sslmode=none;");
                }
                LA(event_name);
                if (MainMenu.isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                }
            }
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
            {
                istimein = true;
            }
            else
            {
                istimein = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)//remove button
        {
            foreach (ListViewItem item in RegisteredListView.SelectedItems)
            {
                SN = item.SubItems[2].Text;
                if (MainMenu.isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess_events;sslmode=none;");
                }


                MainMenu.Insert("delete from " + event_name + " where SN = '" + EnCryptDecrypt.CryptorEngine.Encrypt(SN, true) + "';");

                RegisteredListView.Items.Remove(item);

                if (MainMenu.isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                }

                if (lblCount.Text == "0")
                {
                    MessageBox.Show("There are no more participants!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    lblCount.Text = Convert.ToString(Convert.ToInt32(lblCount.Text) - 1);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Populate_ListView("select Event_Name,Event_Date from event_list;");
            Image dump = pbPubmat.BackgroundImage;
            if (dump != null)
                dump.Dispose();
            pbPubmat.BackgroundImage = Properties.Resources.Blank_BG1;
            pbPubmat.BackgroundImageLayout = ImageLayout.None;
            tbEventName.Text = null;
            tbEventLocation.Text = null;
            event_name = null;
            RegisteredListView.Items.Clear();
            cbTime.Checked = true;
            lblCount.Text = "0";
        }

        private void RegisteredListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.RegisteredListView.Sort();
        }
    }
}
