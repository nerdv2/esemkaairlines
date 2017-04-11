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
    public partial class frmAirportEdit : Form
    {
        public string id_data = frmAirport.id_data;
        public frmAirportEdit()
        {
            InitializeComponent();
            getTimeZone();
            getData();
        }

        private void getTimeZone()
        {
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                cmbTimezone.Items.Add(z.Id);
            }
        }

        public void getData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airport where airport_code = '"+id_data+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCode.Text = reader["airport_code"].ToString();
                    txtName.Text = reader["airport_name"].ToString();
                    txtCountry.Text = reader["airport_country"].ToString();
                    txtCity.Text = reader["airport_city"].ToString();
                    cmbTimezone.Text = reader["airport_timezone"].ToString();
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

        private void frmAirportEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "UPDATE airport SET airport_name = '" + txtName.Text + "', " +
                "airport_city = '" + txtCity.Text + "', " +
                "airport_country = '" + txtCountry.Text + "', " +
                "airport_timezone = '" + cmbTimezone.SelectedItem + "' " +
                "WHERE airport_code = '" + txtCode.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Success!");

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

        private void frmAirportEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmAirport).getData();
        }
    }
}
