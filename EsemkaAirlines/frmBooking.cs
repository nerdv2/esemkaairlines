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
    public partial class frmBooking : Form
    {
        //variable declaration.
        public static string id_booking;
        public static string origin_flight;
        public static string dest_flight;
        public static string flight_type;
        public static string departure_date;
        public static string return_date;

        public frmBooking()
        {
            InitializeComponent();
            getCode();
            getAirport();
        }

        public void getCode()
        {
            int result = 0;
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) AS 'total' FROM flight_booking";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = int.Parse(reader["total"].ToString());
                }
                result++;

                if (result <= 9)
                {
                    txtCode.Text = "BK00" + result;
                    txtCodeRound.Text = "BK00" + result;
                }
                else if (result <= 99)
                {
                    txtCode.Text = "BK0" + result;
                    txtCodeRound.Text = "BK0" + result;
                }
                else if (result <= 999)
                {
                    txtCode.Text = "BK" + result;
                    txtCodeRound.Text = "BK" + result;
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

        private void getAirport()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airport";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet originDS = new DataSet(); //origin checkbox
                DataSet destDS = new DataSet(); //destination checkbox
                DataSet originRoundDS = new DataSet(); //origin roundtrip checkbox
                DataSet destRoundDS = new DataSet(); //destination roundtrip checkbox
                adapter.Fill(originDS);
                adapter.Fill(destDS);
                adapter.Fill(originRoundDS);
                adapter.Fill(destRoundDS);

                cmbOrigin.ValueMember = "airport_code";
                cmbOrigin.DisplayMember = "airport_name";

                cmbDestination.ValueMember = "airport_code";
                cmbDestination.DisplayMember = "airport_name";

                cmbOriginRound.ValueMember = "airport_code";
                cmbOriginRound.DisplayMember = "airport_name";

                cmbDestinationRound.ValueMember = "airport_code";
                cmbDestinationRound.DisplayMember = "airport_name";

                cmbOrigin.DataSource = originDS.Tables[0].DefaultView;
                cmbDestination.DataSource = destDS.Tables[0].DefaultView;
                cmbOriginRound.DataSource = originRoundDS.Tables[0].DefaultView;
                cmbDestinationRound.DataSource = destRoundDS.Tables[0].DefaultView;

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

        private void frmBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == singletripTab)
            {
                DataRowView drvOrigin = cmbOrigin.SelectedItem as DataRowView;
                DataRowView drvDestination = cmbDestination.SelectedItem as DataRowView;

                id_booking = txtCode.Text;
                origin_flight = drvOrigin["airport_code"].ToString();
                dest_flight = drvDestination["airport_code"].ToString();
                flight_type = "single";
                departure_date = cmbDeparture.Text.ToString();

                frmBookingResult form = new frmBookingResult();
                //form.Owner = this;
                form.Show();
                this.Close();

                //MessageBox.Show(id_booking + " + " + origin_flight + " + " + dest_flight + " + " + flight_type + " + " + departure_date);
                
            }
            else if (tabControl1.SelectedTab == roundtripTab)
            {
                DataRowView drvOrigin = cmbOriginRound.SelectedItem as DataRowView;
                DataRowView drvDestination = cmbDestinationRound.SelectedItem as DataRowView;

                id_booking = txtCodeRound.Text;
                origin_flight = drvOrigin["airport_code"].ToString();
                dest_flight = drvDestination["airport_code"].ToString();
                flight_type = "round";
                departure_date = cmbDepartureRound.Text.ToString();
                return_date = cmbReturnRound.Text.ToString();

                frmBookingRoundResult form = new frmBookingRoundResult();
                //form.Owner = this;
                form.Show();
                this.Close();
                
                //MessageBox.Show(id_booking + " + " + origin_flight + " + " + dest_flight + " + " + flight_type + " + " + departure_date);
            }
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
