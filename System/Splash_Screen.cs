using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int val;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void red_rotate_Tick(object sender, EventArgs e)
        {
            
        }

        private void center_fade_Tick(object sender, EventArgs e)
        {
            int rnd = random.Next(2, 5);
            val = progressBar1.Value;
            if(rnd+val>100)
            {
                rnd = 100 - val;
                progressBar1.Value += rnd;
                label2.Text = progressBar1.Value.ToString() + "%";
                fade.Stop();
                Process.Start(@"C:\xampp\mysql\bin\mysqld.exe");
                Process[] pname = Process.GetProcessesByName("mysqld");
                if (pname.Length > 0)
                {
                    MessageBox.Show("MySQL Server Started");
                    MessageBox.Show("Pogi si Christer");
                    Form login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("MySQL Server Failed to Start");
                    Form login = new Login();
                    login.Show();
                    this.Hide();
                }
                
            }
            else if (progressBar1.Value<=100)
            {
                progressBar1.Value += rnd;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
        }
    }
}
