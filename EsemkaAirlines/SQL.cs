using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace EsemkaAirlines
{
    class SQL
    {
        public MySqlConnection getConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=esemka_airlines;uid=root;pwd=development;";
            return conn;
        }
    }
}
