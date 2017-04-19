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
    public partial class frmPassengerAmount : Form
    {
        public string id_booking = frmBookingResult.id_booking;
        public string id_flight = frmBookingResult.id_flight;
        public string id_return = null;
        public frmPassengerAmount()
        {
            InitializeComponent();
            labelID.Text = id_booking;
            labelFlightID.Text = id_flight;
            getFlightData();
        }

        private void getFlightData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code ='"+ id_flight +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    labelArrival.Text = reader["flight_arrival"].ToString();
                    labelDepart.Text = reader["flight_departure"].ToString();
                    labelOrigin.Text = reader["flight_origin"].ToString();
                    labelDest.Text = reader["flight_destination"].ToString();
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

        private void getAvalaible()
        {
            int amount = int.Parse(txtAmount.Text);

        }

        private void saveBookingData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "INSERT INTO flight_booking VALUES(@code, @flightcode, @return, @amount, @date)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", id_booking);
                cmd.Parameters.AddWithValue("@flightcode", id_flight);
                cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@return", id_return);

                cmd.ExecuteNonQuery();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtAmount.Text)){
                saveBookingData();
                launchForm();
            }
        }

        private void launchForm()
        {
            frmSeatChoose form = new frmSeatChoose();
            form.Owner = this;

            int amount = int.Parse(txtAmount.Text);
            for (int i = 0; i < amount; i++)
            {
                form.ShowDialog();
            }
            frmBookingConfirm form2 = new frmBookingConfirm();
            form2.Show();
            this.Close();
        }
    }
}
