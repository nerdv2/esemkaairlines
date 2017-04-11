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
    public partial class frmAirport : Form
    {
        public static string id_data;
        public frmAirport()
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
                string sql = "SELECT * FROM airport";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                dataAirport.DataSource = ds.Tables[0].DefaultView;
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
                string sql = "SELECT * FROM airport WHERE airport_code LIKE '%"+txtSearch.Text+"%' " +
                    "OR airport_name LIKE '%" + txtSearch.Text + "%' " +
                    "OR airport_city LIKE '%" + txtSearch.Text + "%' " +
                    "OR airport_country LIKE '%" + txtSearch.Text + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataAirport.DataSource = ds.Tables[0].DefaultView;
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


        private void frmAirport_Load(object sender, EventArgs e)
        {

        }

        private void dataAirport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataAirport.Rows[e.RowIndex];
                id_data = row.Cells[0].Value.ToString();
                labelSelection.Text = "Selected Data : " + id_data;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Data " + id_data , "Delete Data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteData();
            }
        }

        public void DeleteData()
        {
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "DELETE FROM airport WHERE airport_code='" + id_data + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete data success!");

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAirportAdd form = new frmAirportAdd();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getSpecificData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id_data))
            {
                MessageBox.Show("Select Data First!");
            }
            else
            {
                frmAirportEdit form = new frmAirportEdit();
                form.Owner = this;
                form.ShowDialog();
            }
            
        }

        private void dataAirport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
