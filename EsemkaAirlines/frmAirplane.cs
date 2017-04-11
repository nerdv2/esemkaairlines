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
    public partial class frmAirplane : Form
    {
        public static string id_data;
        public frmAirplane()
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
                string sql = "SELECT * FROM airplane";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataAirplane.DataSource = ds.Tables[0].DefaultView;
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
                string sql = "SELECT * FROM airplane WHERE airplane_code LIKE '%" + txtSearch.Text + "%' " +
                    "OR airplane_type LIKE '%" + txtSearch.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataAirplane.DataSource = ds.Tables[0].DefaultView;
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

        private void dataAirplane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataAirplane.Rows[e.RowIndex];
                id_data = row.Cells[0].Value.ToString();
                labelSelection.Text = "Selected Data : " + id_data;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getSpecificData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAirplaneAdd form = new frmAirplaneAdd();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete data :" + id_data, "Delete Data?", MessageBoxButtons.YesNo);
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
                string sql = "DELETE FROM airplane WHERE airplane_code='" + id_data + "'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAirplaneEdit form = new frmAirplaneEdit();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
