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
    
    public partial class frmBookingRoundResult : Form
    {
        public static string id_booking;
        public static string id_flight;
        public static string id_return_flight;

        public static string depart_date;
        public static string return_date;
        public static string origin;
        public static string dest;

        public frmBookingRoundResult()
        {
            InitializeComponent();
            id_booking = frmBooking.id_booking;
            depart_date = frmBooking.departure_date;
            return_date = frmBooking.return_date;
            origin = frmBooking.origin_flight;
            dest = frmBooking.dest_flight;
            labelID.Text = id_booking;
            //MessageBox.Show(return_date + " + " + origin + " + " + dest);

            getFlight();
            getReturnFlight();
        }

        public void getFlight()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_origin = '"+ origin +"' " + 
                    " AND flight_destination = '"+ dest +"' " + 
                    "AND DATE_FORMAT(flight_departure, '%Y-%m-%d') = '"+ depart_date +"'";
                //MessageBox.Show(sql);
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

        public void getReturnFlight()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_origin = '" + dest + "' " + 
                    " AND flight_destination = '" + origin + "' " + 
                    " AND DATE_FORMAT(flight_departure, '%Y-%m-%d') = '" + return_date + "'";
                //MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                dataReturnResult.DataSource = ds.Tables[0].DefaultView;
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

        private void dataResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataResult.Rows[e.RowIndex];
                id_flight = row.Cells[0].Value.ToString();
                labelSelected.Text = "Selected Data : " + id_flight;
            }
        }

        private void dataReturnResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataReturnResult.Rows[e.RowIndex];
                id_return_flight = row.Cells[0].Value.ToString();
                labelReturnSelected.Text = "Selected Data : " + id_return_flight;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            frmPassengerRoundAmount form = new frmPassengerRoundAmount();
            //form.Owner = this;
            form.Show();
            this.Close();
        }


    }
}
