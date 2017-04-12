using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EsemkaAirlines
{
    public partial class frmMain : Form
    {
        string status;
        public frmMain()
        {
            InitializeComponent();
            status = frmLogin.status;
            initializeView();
        }

        private void initializeView()
        {
            if (status == "admin")
            {
            }
            else if (status == "schedule")
            {
                btnBooking.Enabled = false;
                btnCheckIn.Enabled = false;
                btnFlightData.Enabled = false;
                bookingDataToolStripMenuItem.Enabled = false;
                boardingToolStripMenuItem.Enabled = false;
            }
            else if (status == "booking")
            {

                btnBooking.Enabled = true;
                btnCheckIn.Enabled = false;
                btnFlightData.Enabled = false;
                bookingDataToolStripMenuItem.Enabled = true;
                boardingToolStripMenuItem.Enabled = false;
                scheduleDataToolStripMenuItem.Enabled = false;
                btnAirplane.Enabled = false;
                btnAirport.Enabled = false;
                btnSchedule.Enabled = false;
            }
            else if (status == "boarding")
            {

                btnBooking.Enabled = false;
                btnCheckIn.Enabled = true;
                btnFlightData.Enabled = true;
                bookingDataToolStripMenuItem.Enabled = false;
                boardingToolStripMenuItem.Enabled = true;
                scheduleDataToolStripMenuItem.Enabled = false;
                btnAirplane.Enabled = false;
                btnAirport.Enabled = false;
                btnSchedule.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAirport form = new frmAirport();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAirplane form = new frmAirplane();
            form.Show();
        }

        private void airplaneDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAirplane form = new frmAirplane();
            form.Show();
        }

        private void airportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAirport form = new frmAirport();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSchedule form = new frmSchedule();
            form.Show();
        }

        private void scheduleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchedule form = new frmSchedule();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBooking form = new frmBooking();
            form.Show();
        }

        private void bookingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking form = new frmBooking();
            form.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) 2017 - Gema Aji Wardian/oeltimacreation");
        }
    }
}
