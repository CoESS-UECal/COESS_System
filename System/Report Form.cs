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
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
            
        }

        public static void Insert(string q)
        {
            string query = q;
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query,MainMenu. conn);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    /*if (Registration.isregistration == true)
                    {
                        MessageBox.Show("Invalid ID Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {*/
                    MessageBox.Show(ex.Message);
                    //}
                }
                finally
                {
                   MainMenu.CloseConnection();
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
                        iItem = new ListViewItem(EnCryptDecrypt.CryptorEngine.Decrypt( dataReader[0].ToString(),true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[1].ToString(),true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[2].ToString(),true));
                        iItem.SubItems.Add(EnCryptDecrypt.CryptorEngine.Decrypt(dataReader[3].ToString(),true));
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
        public void Populate_Combobox(string myquery)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            string query = myquery;
            if (MainMenu.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, MainMenu.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboBox2.Items.Add(dataReader[0].ToString());
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
            Insert("Delete from report_table;");
            if (comboBox3.Text != "All")
            {
                Populate_ListView("Select ln,fn,sn,year_level from member_list where year_level = '" +EnCryptDecrypt.CryptorEngine.Encrypt(comboBox3.Text,true) + "';");
                foreach (ListViewItem item in listView1.Items)
                {
                    string sn, ln, fn, yr;
                    ln = item.SubItems[0].Text;
                    fn = item.SubItems[1].Text;
                    sn = item.SubItems[2].Text;
                    yr = item.SubItems[3].Text;
                    Insert("insert into report_table values ('" + ln + "','" + fn + "','" + sn + "','" + yr + "')");
                }
            }
            else
            {
                Populate_ListView("Select ln,fn,sn,year_level from member_list;");
                foreach (ListViewItem item in listView1.Items)
                {
                    string sn, ln, fn, yr;
                    ln = item.SubItems[0].Text;
                    fn = item.SubItems[1].Text;
                    sn = item.SubItems[2].Text;
                    yr = item.SubItems[3].Text;
                    Insert("insert into report_table values ('" + ln + "','" + fn + "','" + sn + "','" + yr + "')");
                }
            }
          
            crystalReportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=" +comboBox1.Text+";");
            if(comboBox1.Text == "CoESS")
            {
                Populate_Combobox("Show Tables where tables_in_coess = 'member_list'");
            }
            else
            {
                Populate_Combobox("Show Tables");
            }
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;");

            Insert("Delete from report_table;");

        }
    }
}