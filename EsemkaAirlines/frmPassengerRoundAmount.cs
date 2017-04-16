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
    public partial class frmPassengerRoundAmount : Form
    {
        public static string id_booking = frmBookingRoundResult.id_booking;
        public static string id_flight = frmBookingRoundResult.id_flight;
        public static string id_return_flight = frmBookingRoundResult.id_return_flight;
        public frmPassengerRoundAmount()
        {
            InitializeComponent();
            labelID.Text = id_booking;
            getFlightInfo();
            getReturnFlightInfo();
        }

        public void getFlightInfo()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code = '" + id_flight + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    labelFlightID.Text = reader["flight_code"].ToString();
                    labelOrigin.Text = reader["flight_origin"].ToString();
                    labelDest.Text = reader["flight_destination"].ToString();
                    labelDepart.Text = reader["flight_departure"].ToString();
                    labelArrival.Text = reader["flight_arrival"].ToString();
                }
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

        public void getReturnFlightInfo()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code = '"+ id_return_flight +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    labelFlightRoundID.Text = reader["flight_code"].ToString();
                    labelOriginRound.Text = reader["flight_origin"].ToString();
                    labelDestRound.Text = reader["flight_destination"].ToString();
                    labelDepartRound.Text = reader["flight_departure"].ToString();
                    labelArrivalRound.Text = reader["flight_arrival"].ToString();
                }
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
    }
}
