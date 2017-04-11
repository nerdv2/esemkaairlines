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
    public partial class frmAirportAdd : Form
    {
        public frmAirportAdd()
        {
            InitializeComponent();
            getTimeZone();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void getTimeZone()
        {
            foreach(TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones()){
                cmbTimezone.Items.Add(z.Id);
            }
        }

        private void saveData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "INSERT INTO airport VALUES(@code, @name, @country, @city, @timezone)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@timezone", cmbTimezone.SelectedItem);

                cmd.ExecuteNonQuery();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtName.Text = "";
        }

        private void frmAirportAdd_Load(object sender, EventArgs e)
        {

        }

        private void frmAirportAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmAirport).getData();
        }
    }
}
