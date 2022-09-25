using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace System
{
    public partial class MainMenu : Form
    {
        //"server=localhost;uid=root;pwd=;database=coess;"                  // database connection strings
        //"server=localhost;uid=root;pwd=;database=coess_events;"           //

        //Database connection variables
        public static MySqlConnection conn;
        public static string myConnectionString;
        public static bool isMaster;

        public MainMenu()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        int user_accounts;
        bool coessdb;
        bool coess_eventsdb;
        bool report_table;
        string coess = "coess";
        string coess_events = "coess_events";
        string reporttable = "report_table_1";
        CrystalReport2 report = new CrystalReport2();

        public void checkdb(string ID, string check)
        {
            string query = "show databases like '" + ID + "';";
            MySqlCommand command;
            if (MainMenu.OpenConnection())
            {
                try
                {
                    if (ID == "report_table_1")
                    {
                        command = new MySqlCommand("show tables where tables_in_coess = 'report_table_1';", MainMenu.conn);
                    }
                    else
                    {
                        command = new MySqlCommand(query, MainMenu.conn);
                    }
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (check == reader[0].ToString())
                        {
                            if (check == "coess")
                            {
                                coessdb = true;
                            }
                            if (check == "coess_events")
                            {
                                coess_eventsdb = true;
                            }
                            if (check == "report_table_1")
                            {
                                report_table = true;
                            }
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

        public void checkuser()
        {
            string query = "select count(user) from mysql.user where user = 'access'";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user_accounts = Convert.ToInt32(reader[0].ToString());
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

        //create database
        public static void createdb(string q)
        {
            string query = q;
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

        //Initialize database connection strings
        public static void Initialize(string connstr)
        {
            myConnectionString = connstr;
            conn = new MySqlConnection(myConnectionString);
        }

        //Opening connection to database
        public static bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //closing connection to database
        public static bool CloseConnection()
        {
            try
            {
                conn.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert into database
        public static void Insert(string q)
        {
            string query = q;
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Operation succeeded.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    if (Registration.isregistration == true)
                    {
                        MessageBox.Show("No Event Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    CloseConnection();
                }
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
                        iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[0].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[2].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[3].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[4].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[5].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[6].ToString(), true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[7].ToString(), true));
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

        private void imageLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Always put all Images in C:\\COESS\\Images\\.\nThank You.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This CoESS Database System is created by CoESS 2018-2019." + Environment.NewLine +
            "\n©Christer Jude A. Mananquil, Vice President - Internal (2018-2019)\n©Charles Edward D. Bernardo, Lead Programmer (2018-2019)"+
            "\n©Mark Generson D. Espiritu, " +"Lead Designer (2018-2019)\n©Kent Andrew Norca, Lead Designer (2019-2020"+
            "\n\nAll Rights Reserved.\nNo part of this system can be reproduced nor modified without consent from the developers.", "About",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("You will be Logged Out. Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Form login = new Login();
                login.Show();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress ;)", "O P S", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form access = new Access();
            access.ShowDialog();
            if (Access.access)
            {
                Form report = new Report_Form();
                report.Show();
            }
        }

        private void localhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isMaster = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isMaster = false;
        }

        private void createSlaveAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu.Initialize("server=localhost;user=root;sslmode=none;");
            checkuser();
            if (user_accounts != 1)
            {
                Insert("create user 'access'@'%';");
                Insert("GRANT USAGE ON *.* TO 'access'@'%';");
                Insert("GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER ON `coess\\_events`.*TO 'access'@'%';");
                Insert("GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER ON `coess`.*TO 'access'@'%';");
                Insert("GRANT ALL PRIVILEGES ON `access\\_ %`.*TO 'access'@'%';");

                MessageBox.Show("User Accounts Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form access = new Access();
            access.ShowDialog();
            if (Access.access)
            {
                crystalReportViewer1.ReportSource = report;
                if (isMaster == true)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                }
                else
                {
                    MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                }
                checkdb("report_table_1", reporttable);
                if (!report_table)
                {
                    if (isMaster == true)
                    {
                        MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                    }
                    else
                    {
                        MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                    }
                    Insert("create table report_table_1 (First varchar(255) not null, Middle varchar(255) not null, Last varchar(255) not null,Year_Level varchar(255) not null, SN varchar(255) not null, Guardian_Name varchar(255) not null, `Guardian_Contact` VARCHAR(255) NOT NULL,bday varchar(255) not null);");
                    Insert("Delete from report_table_1;");

                    Populate_ListView("Select fn,mi,ln,year_level,SN,Guard_name,Guard_contact,bday from member_list;");
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string ln, mi, fn, yr, sn, guard_name, guard_contact, bday;
                        fn = item.SubItems[0].Text;
                        mi = item.SubItems[1].Text;
                        ln = item.SubItems[2].Text;
                        yr = item.SubItems[3].Text;
                        sn = item.SubItems[4].Text;
                        guard_name = item.SubItems[5].Text;
                        guard_contact = item.SubItems[6].Text;
                        bday = item.SubItems[7].Text;
                        Insert("insert into report_table_1 values ('" + fn + "','" + mi + "','" + ln + "','" + yr + "','" + sn + "','" + guard_name + "','" + guard_contact + "','" + bday + "');");
                    }

                    crystalReportViewer1.RefreshReport();
                    crystalReportViewer1.ExportReport();
                    Insert("Delete from report_table_1;");
                }
                else
                {
                    if (isMaster == true)
                    {
                        MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                    }
                    else
                    {
                        MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                    }
                    Insert("Delete from report_table_1;");

                    Populate_ListView("Select fn,mi,ln,year_level,SN,Guard_name,Guard_contact,bday from member_list;");
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string ln, mi, fn, yr, sn, guard_name, guard_contact, bday;
                        fn = item.SubItems[0].Text;
                        mi = item.SubItems[1].Text;
                        ln = item.SubItems[2].Text;
                        yr = item.SubItems[3].Text;
                        sn = item.SubItems[4].Text;
                        guard_name = item.SubItems[5].Text;
                        guard_contact = item.SubItems[6].Text;
                        bday = item.SubItems[7].Text;
                        Insert("insert into report_table_1 values ('" + fn + "','" + mi + "','" + ln + "','" + yr + "','" + sn + "','" + guard_name + "','" + guard_contact + "','" + bday + "');");
                    }

                    crystalReportViewer1.RefreshReport();
                    crystalReportViewer1.ExportReport();
                    Insert("Delete from report_table_1;");

                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form access = new Access();
            access.ShowDialog();
            if (Access.access)
            {
                Form devmode = new DevMode();
                devmode.Show();
                Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            isMaster = true;
            if (isMaster)
            {
                toolStripLabel3.BackgroundImage = System.Properties.Resources.on_button;
                toolStripLabel2.Text = "Master";
                createDatabaseToolStripMenuItem.Visible = true;
                createSlaveAccountToolStripMenuItem.Visible = true;
            }
            else
            {
                toolStripLabel3.BackgroundImage = System.Properties.Resources.off_button;
                toolStripLabel2.Text = "Slave";
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (!isMaster)
            {
                isMaster = true;
                Initialize("server=localhost;user=root;sslmode=none;");
                createDatabaseToolStripMenuItem.Visible = true;
                createSlaveAccountToolStripMenuItem.Visible = true;
                toolStripLabel3.BackgroundImage = System.Properties.Resources.on_button;
                toolStripLabel2.Text = "Master";
            }
            else
            {
                createDatabaseToolStripMenuItem.Visible = false;
                createSlaveAccountToolStripMenuItem.Visible = false;
                toolStripLabel3.BackgroundImage = System.Properties.Resources.off_button;
                isMaster = false;
                toolStripLabel2.Text = "Slave";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel5.Text = DateTime.Now.ToString("H:mm:ss tt");
        }

        private void convertPlaintextCSVToEncryptedCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            Form access = new Access();
            access.ShowDialog();
            if (Access.access)
            {
                Form memberlist = new Member_List();
                memberlist.Show();
                Close();
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Form newmember = new New_Member();
            newmember.Show();
            Close();
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            Form newevent = new New_Event();
            newevent.Show();
            Close();
        }

        private void btnEventList_Click(object sender, EventArgs e)
        {
            Form eventlist = new Event_List();
            eventlist.Show();
            Close();
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to check if the database exists?", "Database Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Initialize("server=localhost;uid=root;pwd=;sslmode=none;");
                checkdb("coess", coess);
                if (!coessdb)
                {
                    createdb("create database coess;");
                    Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                    createdb("create table event_list (Event_No int(3) auto_increment, Event_Name varchar(300) not null, Event_Date varchar(255) not null, Event_Location varchar(300) not null, Event_Pubmat varchar(300) null, primary key(Event_No));");
                    createdb("create table member_list (ID_No int(3) auto_increment, SN varchar(255) not null, FN varchar(255) not null, MI varchar(255) not null, LN varchar(255) not null, Email varchar(255) not null, Contact_No varchar(255) not null, BDay varchar(255) not null, Age varchar(255) not null, Year_Level varchar(255) not null, Comm varchar(255) not null, Guard_Name varchar(255) not null, Guard_Contact varchar(255) not null, Membership varchar(255) not null, ID_Address varchar(255) null, primary key(ID_No));");
                    createdb("create table report_table (LN varchar(255) null, FN varchar(255) null, SN varchar(255) not null, Yr_Lvl varchar(255) null, primary key(SN));");
                    MessageBox.Show("CoESS Database has been created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CoESS Database Exists!", "Success", MessageBoxButtons.OK);
                }
                checkdb("coess_events", coess_events);
                if (!coess_eventsdb)
                {
                    Initialize("server=localhost;uid=root;pwd=;sslmode=none;");
                    createdb("create database coess_events;");
                    MessageBox.Show("CoESS Events Database has been created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CoESS Events Database Exists!", "Success", MessageBoxButtons.OK);
                }
            }
        }

        private void importCoESSRegistrySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process coess = Process.Start("regedit.exe", "/s "+Application.StartupPath+"\\Resources\\coess.reg");
            coess.WaitForExit();
            Process coess_event = Process.Start("regedit.exe", "/s "+Application.StartupPath+ "\\Resources\\coess_events.reg");
            coess_event.WaitForExit();
            if(coess.HasExited && coess_event.HasExited)
            {
                MessageBox.Show("Registry Entries created!", "Succcess");
            }
            else
            {
                MessageBox.Show("Registry Entries failed!", "Fail");
            }
        }
    }
}
