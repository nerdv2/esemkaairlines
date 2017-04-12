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
    public partial class frmBookingConfirm : Form
    {
        public string id_booking;
        public string id_flight;
        int price, amount, total;

        public frmBookingConfirm()
        {
            InitializeComponent();
            id_booking = frmBookingResult.id_booking;
            id_flight = frmBookingResult.id_flight;
            getFlight();
            getPassenger();
            getPrice();
        }

        public void getFlight()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code = '"+ id_flight +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataFlight.DataSource = ds.Tables[0].DefaultView;
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

        public void getPassenger()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT passenger.* FROM passenger, flight_ticket " + 
                    "WHERE passenger.passenger_code = flight_ticket.ticket_passengercode " + 
                    "AND flight_ticket.ticket_bookingcode = '" + id_booking + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataPassenger.DataSource = ds.Tables[0].DefaultView;
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

        private void getPrice()
        {
            
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT flight_schedule.`flight_price`, flight_booking.`booking_amount` " + 
                    "FROM flight_schedule, flight_booking WHERE " + 
                    "flight_schedule.`flight_code` = flight_booking.`booking_flightcode` AND flight_booking.booking_code = '"+ id_booking +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    price = int.Parse(reader["flight_price"].ToString());
                    amount = int.Parse(reader["booking_amount"].ToString());
                }

                total = price * amount;
                labelPrice.Text = total.ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
