using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class Registration : Form
    {

        public Event_List eventlist { get; set; } //This is also used along with the delcaration at the bottom to manipulate controls on other forms, like setting labels or updating listviews.
                                                  //Diba minsan may gusto tayong imanimpulate na controls sa kabilang form, 
                                                  //for example mag uupdate yung listview sa kabilang form using this form.
        int ID;
        int query_ID;

        public static bool isregistration = false;
        public static bool duplicate = false;

        //This declares that even when a new form is called, like when Form registration = new Registration() is used, the forms being created is still the same.(OOP thing)
        public Registration(Event_List _form1)
        {
            eventlist = _form1;
            InitializeComponent();
        }

        //This is used to allow the user to move the form even when there are no handles/windows.
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

        public static void GetSN(int id)//Get Student Number/ Search for duplicates on the list
        {
            int dup = 1;
            string query = "select count(*) from " + Event_List.event_name + " where ID_No = " + id + ";";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dup == Convert.ToInt32(dataReader[0].ToString()))
                        {
                            duplicate = true;
                        }
                        else
                        {
                            duplicate = false;
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

        public void Max_ID()//Gets the maximum ID number for use in validation
        {
            string query = "select max(ID_No) from member_list;";
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        query_ID = Convert.ToInt32(dataReader[0]);
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
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (eventlist.checkBox1.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ID = Convert.ToInt32(textBox1.Text);

                    if (MainMenu.isMaster == true)
                    {
                        MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                    }
                    else
                    {
                        MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                    }

                    Max_ID();

                    if (ID <= query_ID)
                    {
                        if (MainMenu.isMaster == true)
                        {
                            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
                        }
                        else
                        {
                            MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess_events;sslmode=none;");
                        }

                        GetSN(ID);

                        if (!duplicate)
                        {
                            MainMenu.Insert("insert into " + Event_List.event_name + " (ID_No, FN, LN, SN, Year_Level) select ID_No, FN, LN, SN,Year_Level from coess.member_list where ID_No = " + ID + ";");
                            MainMenu.Insert("update " + Event_List.event_name + " set Time_In = '" + DateTime.Now.ToString("HH:mm") + "' where ID_No = " + ID + ";");
                            textBox1.Text = null;
                            eventlist.LA(Event_List.event_name);

                            if (MainMenu.isMaster == true)
                            {
                                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                            }
                            else
                            {
                                MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Duplicate Entry Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Number! Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox1.Text = null;
                    }
                }
            }
            else if (eventlist.checkBox1.Checked == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ID = Convert.ToInt32(textBox1.Text);
                    if (MainMenu.isMaster == true)
                    {
                        MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                    }
                    else
                    {
                        MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                    }

                    Max_ID();

                    if (ID <= query_ID)
                    {
                        if (MainMenu.isMaster == true)
                        {
                            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;sslmode=none;");
                        }
                        else
                        {
                            MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess_events;sslmode=none;");
                        }
                        MainMenu.Insert("update " + Event_List.event_name + " set Time_Out = '" + DateTime.Now.ToString("HH:mm") + "' where ID_No = " + ID + ";");
                        textBox1.Text = null;
                        eventlist.LA(Event_List.event_name);

                        if (MainMenu.isMaster == true)
                        {
                            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
                        }
                        else
                        {
                            MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Number! Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox1.Text = null;
                    }
                }
            }
        }
    }
}
