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
    public partial class frmAirplaneAdd : Form
    {
        public frmAirplaneAdd()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtRow.Text = "";
            txtSeat.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int seat = int.Parse(txtSeat.Text);
            int row = int.Parse(txtRow.Text);
            int total = seat * row;

            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "INSERT into airplane VALUES(@code, @type, @total, @seatperrow, @numrow)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@type", txtName.Text);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@seatperrow", txtSeat.Text);
                cmd.Parameters.AddWithValue("@numrow", txtRow.Text);
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

        private void frmAirplaneAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmAirplane).getData();
        }

        private void frmAirplaneAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
