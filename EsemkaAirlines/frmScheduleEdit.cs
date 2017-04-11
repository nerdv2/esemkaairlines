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
    public partial class frmScheduleEdit : Form
    {
        public frmScheduleEdit()
        {
            InitializeComponent();
            getAirplane();
            getAirport();
            txtCode.Text = frmSchedule.id_data;
            getData();
        }

        private void getData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code = '"+txtCode.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbAirplane.SelectedValue = reader["flight_airplane"].ToString();
                    cmbOrigin.SelectedValue = reader["flight_origin"].ToString();
                    cmbDestination.SelectedValue = reader["flight_destination"].ToString();
                    txtArrival.Text = reader["flight_arrival"].ToString();
                    txtDeparture.Text = reader["flight_departure"].ToString();
                    txtPrice.Text = reader["flight_price"].ToString();
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
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                adapter.Fill(ds);
                adapter.Fill(ds2);

                cmbOrigin.DisplayMember = "airport_name";
                cmbOrigin.ValueMember = "airport_code";

                cmbDestination.DisplayMember = "airport_name";
                cmbDestination.ValueMember = "airport_code";

                cmbOrigin.DataSource = ds.Tables[0].DefaultView;
                cmbDestination.DataSource = ds2.Tables[0].DefaultView;

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

        private void getAirplane()
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

                cmbAirplane.DisplayMember = "airplane_type";
                cmbAirplane.ValueMember = "airplane_code";

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

        private void frmScheduleEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
