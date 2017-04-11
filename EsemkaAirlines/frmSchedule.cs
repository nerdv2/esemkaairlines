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
    public partial class frmSchedule : Form
    {
        public static string id_data;
        public frmSchedule()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataSchedule.DataSource = ds.Tables[0].DefaultView;
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
        private void getSpecificData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM flight_schedule WHERE flight_code LIKE '%"+txtSearch.Text+"%' OR " +
                    "flight_origin LIKE '%" + txtSearch.Text + "%' OR flight_destination LIKE '%" + txtSearch.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataSchedule.DataSource = ds.Tables[0].DefaultView;
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

        private void frmSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void dataSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataSchedule.Rows[e.RowIndex];
                id_data = row.Cells[0].Value.ToString();
                labelSelection.Text = "Selected Data : " + id_data;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmScheduleAdd form = new frmScheduleAdd();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Data?", "esemkaAirlines", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteData();
            }
            
        }

        private void deleteData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "DELETE FROM flight_schedule WHERE flight_code = '" + id_data + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Data Success!");
                getData();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getSpecificData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmScheduleEdit edit = new frmScheduleEdit();
            edit.Owner = this;
            edit.ShowDialog();
        }

        private void dataSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}