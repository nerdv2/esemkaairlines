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
    public partial class frmSeatChoose : Form
    {
        public static string id_booking;
        public static string id_flight;
        public static string id_airplane;
        int totalrow, totalseat = 0;
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public frmSeatChoose()
        {
            InitializeComponent();
            id_booking = frmBookingResult.id_booking;
            id_flight = frmBookingResult.id_flight;
            id_airplane = frmBookingResult.id_airplane;
            labelID.Text = id_booking;
            labelFlightID.Text = id_flight;
            getPassenger();
            getSeatInfo();
            generateSeat();
        }

        private void getPassenger()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT passenger_code, CONCAT(passenger.`passenger_firstname`, ' ', passenger.`passenger_lastname`) " + 
                    " AS passenger_name FROM passenger";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                cmbPassenger.DisplayMember = "passenger_name";
                cmbPassenger.ValueMember = "passenger_code";

                cmbPassenger.DataSource = ds.Tables[0].DefaultView;
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

        private void getSeatInfo()
        {
            
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airplane WHERE airplane_code = '"+ id_airplane +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalrow = int.Parse(reader["airplane_seatperrow"].ToString());
                    totalseat = int.Parse(reader["airplane_numrow"].ToString());
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

        private void generateSeat()
        {
            for (int i = 0; i < totalrow; i++)
            {
                cmbSeatRow.Items.Add(alphabet[i]);
            }

            for (int i = 1; i <= totalseat; i++)
            {
                cmbSeatNo.Items.Add(i);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getPassenger();
        }

        private void frmSeatChoose_Load(object sender, EventArgs e)
        {

        }
    }
}
