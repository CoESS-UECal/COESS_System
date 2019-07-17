using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAUEK_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Marker.Height = HomeButton.Height;
            Marker.Top = HomeButton.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            distance = Marker.Top - HomeButton.Top;
            checksize();
            timer1.Start(); 
            if (hcollapsed)
            {
                
                HomeButton.Enabled = false;
                EventListButton.Enabled = false;
                EventRegButton.Enabled = false;
                PrintButton.Enabled = false;
                HomeTimer.Start();
                if (!ercollapsed)
                {
                    EventRegTimer.Start();
                }
                if(!elcollapsed)
                {
                    EventListTimer.Start();
                }
                if(!pcollapsed)
                {
                    PrintTimer.Start();
                }
            }
            
        }

        private void EventRegButton_Click(object sender, EventArgs e)
        {

            distance = Marker.Top - EventRegButton.Top;
            checksize();
            timer1.Start();

            if (ercollapsed)
            {
                HomeButton.Enabled = false;
                EventListButton.Enabled = false;
                EventRegButton.Enabled = false;
                PrintButton.Enabled = false;
                if (!hcollapsed)
                {
                    HomeTimer.Start();
                }
                EventRegTimer.Start();
                if (!elcollapsed)
                { 
                    EventListTimer.Start();

                }
                if(!pcollapsed)
                {
                    PrintTimer.Start();
                }
            }
        }

        private void EventListButton_Click(object sender, EventArgs e)
        {

            distance = Marker.Top - EventListButton.Top;
            checksize();
            timer1.Start();
            if (elcollapsed)
            {
                HomeButton.Enabled = false;
                EventListButton.Enabled = false;
                EventRegButton.Enabled = false;
                PrintButton.Enabled = false;
                EventListTimer.Start();
                if(!hcollapsed)
                {
                    HomeTimer.Start();
                }
                if(!ercollapsed)
                {
                    EventRegTimer.Start();
                }
                if(!pcollapsed)
                {
                    PrintTimer.Start();
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            distance = Marker.Top - PrintButton.Top;
            checksize();
            timer1.Start();
            if (pcollapsed)
            {
                HomeButton.Enabled = false;
                EventListButton.Enabled = false;
                EventRegButton.Enabled = false;
                PrintButton.Enabled = false;
                PrintTimer.Start();
                if (!hcollapsed)
                {
                    HomeTimer.Start();
                }
                if (!ercollapsed)
                {
                    EventRegTimer.Start();
                }
                if (!elcollapsed)
                {
                    EventListTimer.Start();
                }
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            HomeScreen.Size = HomeScreen.MaximumSize;
            EventReg.Size = EventReg.MinimumSize;
            EventList.Size = EventList.MinimumSize;
            Print.Size = Print.MinimumSize;
            checksize();
        }
        #region Transition
        private bool hcollapsed,ercollapsed,elcollapsed,pcollapsed;
        private void HomeTimer_Tick(object sender, EventArgs e)
        {

            if (hcollapsed)
            {
                HomeScreen.BringToFront();
                HomeScreen.Width += 100;
                if(HomeScreen.Size==HomeScreen.MaximumSize)
                {
                    HomeTimer.Stop();
                    hcollapsed = false;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }
            else
            {
                HomeScreen.SendToBack();
                HomeScreen.Width -= 100;
                if (HomeScreen.Size == HomeScreen.MinimumSize)
                {
                    HomeTimer.Stop();
                    hcollapsed = true;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
                
            }

        }
        private void EventRegTimer_Tick(object sender, EventArgs e)
        {
            if (ercollapsed)
            {
                EventReg.BringToFront();
                EventReg.Width += 100;
                if (EventReg.Size == EventReg.MaximumSize)
                {
                    EventRegTimer.Stop();
                    ercollapsed = false;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }
            else
            {
                EventReg.SendToBack();
                EventReg.Width -= 100;
                if (EventReg.Size == EventReg.MinimumSize)
                {
                    EventRegTimer.Stop();
                    ercollapsed = true;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }

        }

        private void EventListTimer_Tick(object sender, EventArgs e)
        {
            if (elcollapsed)
            {
                EventList.BringToFront();
                EventList.Width += 100;
                if (EventList.Size == EventList.MaximumSize)
                {
                    EventListTimer.Stop();
                    elcollapsed = false;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }
            else
            {
                EventList.SendToBack();
                EventList.Width -= 100;
                if (EventList.Size == EventList.MinimumSize)
                {
                    EventListTimer.Stop();
                    elcollapsed = true;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (distance < 0)
            {
                Marker.Top += 55;
                distance += 55;
            }
            if(distance > 0)
            {
                Marker.Top -= 55;
                distance -= 55;
            }
             if(distance == 0)
            {
                timer1.Stop();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintTimer_Tick(object sender, EventArgs e)
        {
            if (pcollapsed)
            {
                Print.BringToFront();
                Print.Width += 100;
                if (Print.Size == Print.MaximumSize)
                {
                    PrintTimer.Stop();
                    pcollapsed = false;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }
            else
            {
                Print.SendToBack();
                Print.Width -= 100;
                if (Print.Size == Print.MinimumSize)
                {
                    PrintTimer.Stop();
                    pcollapsed = true;
                    HomeButton.Enabled = true;
                    EventListButton.Enabled = true;
                    EventRegButton.Enabled = true;
                    PrintButton.Enabled = true;
                }
            }

        }
        #endregion
        int distance;
        private void checksize()
        {
            if (HomeScreen.Size == HomeScreen.MaximumSize)
            {
                hcollapsed = false;
            }
            else
            {
                hcollapsed = true;
            }
            if (EventReg.Size == EventReg.MaximumSize)
            {
                ercollapsed = false;
            }
            else
            {
                ercollapsed = true;
            }
            if (EventList.Size == EventList.MaximumSize)
            {
                elcollapsed = false;
            }
            else
            {
                elcollapsed = true;
            }
            if (Print.Size == Print.MaximumSize)
            {
                pcollapsed = false;
            }
            else
            {
                pcollapsed = true;
            }
        }
    }
}
    