using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EsemkaAirlines
{
    public partial class frmBookingResult : Form
    {
        public static string id_flight;

        public static string id_booking = frmBooking.id_booking;
        public string origin_flight = frmBooking.origin_flight;
        public string dest_flight = frmBooking.dest_flight;
        public string departure_date = frmBooking.departure_date;

        public frmBookingResult()
        {
            InitializeComponent();
            labelID.Text = frmBooking.id_booking;
            getFlight();
        }

        public void getFlight()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_origin = '"+ origin_flight +"' AND " +
                    "flight_destination = '"+ dest_flight +"' AND " +
                        "DATE_FORMAT(flight_departure, '%Y-%m-%d') = '"+departure_date+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                dataResult.DataSource = ds.Tables[0].DefaultView;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmBookingResult_Load(object sender, EventArgs e)
        {

        }

        private void dataResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getFlight();
        }

        private void dataResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataResult.Rows[e.RowIndex];
                id_flight = row.Cells[0].Value.ToString();
                labelSelected.Text = "Selected Data : " + id_flight;
            }
        }

        private void labelSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            frmPassengerAmount form = new frmPassengerAmount();
            form.Owner = this;
            form.Show();
        }
    }
}
