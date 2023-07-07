using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РЖД_Нарядчики
{
      class DataBase
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-33GFS78;Initial Catalog=DataBaseRZD;Integrated Security=True");
        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
