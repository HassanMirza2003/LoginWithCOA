using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbCon
    {
        private SqlConnection conn;
        private SqlDataReader reader;
        public DbCon()
        {
            conn= new SqlConnection("Data Source=DESKTOP-GNUBDV8;Initial Catalog=UserLogin;Integrated Security=True;Trust Server Certificate=True");
        }
        public void OpenConnection()
        {
            conn.Open();
        }
        public void CloseConnection()
        { 
            conn.Close();
        }
        public SqlDataReader SrchByReader(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry,conn);
            reader = cmd.ExecuteReader();
            return reader;

        }
    }
}
