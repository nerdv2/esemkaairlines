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
        public frmMain()
        {
            InitializeComponent();
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
    }
}
