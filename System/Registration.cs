﻿using System;
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
    public partial class Registration : Form
    {
        
        public Event_List eventlist { get; set; }

        public Registration(Event_List _form1)
        {
            eventlist = _form1;
            InitializeComponent();
        }
        int ID;
        int query_ID;
        public static bool isregistration = false;
        public void Max_ID()
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


        private void Registration_Load(object sender, EventArgs e)
        {
            isregistration = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ID = Convert.ToInt32(textBox1.Text);
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
                Max_ID();
                if(ID<=query_ID)
                {
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess_events;");
                    MainMenu.Insert("insert into " + Event_List.event_name + " (ID_No, FN, LN, SN) select ID_No, FN, LN, SN from coess.member_list where ID_No = " + ID + ";");
                    textBox1.Text = null;
                    eventlist.LA(Event_List.event_name);
                    MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");
                }
                else
                {
                    MessageBox.Show("Invalid ID Number! Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Text = null;
                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
