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
    public partial class frmAirplaneEdit : Form
    {
        public string id_data = frmAirplane.id_data;
        public frmAirplaneEdit()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM airplane WHERE airplane_code='"+id_data+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCode.Text = reader["airplane_code"].ToString();
                    txtName.Text = reader["airplane_type"].ToString();
                    txtSeat.Text = reader["airplane_seatperrow"].ToString();
                    txtRow.Text = reader["airplane_numrow"].ToString();
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

        public void updateData()
        {
            int seat = int.Parse(txtSeat.Text);
            int row = int.Parse(txtRow.Text);
            int total = seat * row;

            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "UPDATE airplane SET airplane_type ='" + txtName.Text + "', " +
                    "airplane_totalseat ='" + total + "', " +
                    "airplane_seatperrow ='" + txtSeat.Text + "', " +
                    "airplane_numrow ='" + txtRow.Text + "' " +
                    "WHERE airplane_code = '"+txtCode.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Data Success!");
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

        private void frmAirplaneEdit_Load(object sender, EventArgs e)
        {

        }

        private void frmAirplaneEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmAirplane).getData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
