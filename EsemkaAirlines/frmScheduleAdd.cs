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
    public partial class frmScheduleAdd : Form
    {
        public frmScheduleAdd()
        {
            InitializeComponent();
            getAirport();
            getFlight();
        }

        public void getAirport()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airport";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                adapter.Fill(ds);
                adapter.Fill(ds2);

                cmbDestination.ValueMember = "airport_code";
                cmbDestination.DisplayMember = "airport_name";

                cmbOrigin.ValueMember = "airport_code";
                cmbOrigin.DisplayMember = "airport_name";

                cmbDestination.DataSource = ds.Tables[0].DefaultView;
                cmbOrigin.DataSource = ds2.Tables[0].DefaultView;


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

        public void getFlight()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airplane";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                cmbAirplane.ValueMember = "airplane_code";
                cmbAirplane.DisplayMember = "airplane_type";

                cmbAirplane.DataSource = ds.Tables[0].DefaultView;
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

        private void frmScheduleAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "INSERT INTO flight_schedule VALUES(@code,@origin,@destination,@departure " +
                    ",@arrival,@duration,@airplane,@price)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                DataRowView drvOrigin = cmbOrigin.SelectedItem as DataRowView;
                DataRowView drvDest = cmbDestination.SelectedItem as DataRowView;
                DataRowView drvAirplane = cmbAirplane.SelectedItem as DataRowView;

                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@origin", drvOrigin["airport_code"].ToString());
                cmd.Parameters.AddWithValue("@destination", drvDest["airport_code"].ToString());
                cmd.Parameters.AddWithValue("@departure", txtDeparture.Text);
                cmd.Parameters.AddWithValue("@arrival", txtArrival.Text);
                cmd.Parameters.AddWithValue("@duration", calculateTime());
                cmd.Parameters.AddWithValue("@airplane", drvAirplane["airplane_code"].ToString());
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Input Data Success!");
                this.Close();
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

        private TimeSpan calculateTime()
        {
            DateTime departure = Convert.ToDateTime(txtDeparture.Text);
            DateTime arrival = Convert.ToDateTime(txtArrival.Text);
            TimeSpan duration = departure.Subtract(arrival);
            return duration;
        }

        private void frmScheduleAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmSchedule).getData();
        }
    }
}
