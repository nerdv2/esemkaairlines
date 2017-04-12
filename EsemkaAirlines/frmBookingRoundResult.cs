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
        public static string origin;
        public static string dest;

        public frmBookingRoundResult()
        {
            InitializeComponent();
            id_booking = frmBooking.id_booking;
            depart_date = frmBooking.departure_date;
            origin = frmBooking.origin_flight;
            dest = frmBooking.dest_flight;
            labelID.Text = id_booking;
            //MessageBox.Show(depart_date + " + " + origin + " + " + dest);

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

        }


    }
}
