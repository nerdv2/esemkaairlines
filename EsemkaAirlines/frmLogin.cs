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
    public partial class frmLogin : Form
    {
        string password;
        public static string status;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void processLogin()
        {
            
            SQL con = new SQL();
            MySqlConnection conn = con.getConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM user WHERE user_name = '"+ txtUsername.Text +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    password = reader["user_password"].ToString();
                    status = reader["user_role"].ToString();
                }

                if (password.Equals(txtPassword.Text))
                {
                    showForm();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void showForm()
        {
            frmMain form = new frmMain();
            form.Show();
            this.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            processLogin();
        }
    }
}
