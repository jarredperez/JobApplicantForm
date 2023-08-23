using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SQLConnectionClass
    {

        public string connectionString = "Data Source=JARRED_XPS15;Initial Catalog=EFDB;Integrated Security=True";
        public SqlConnection con = null;
        public SqlCommand cmd = null;

        public void OpenConnection() 
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public void CreateCommand(string queryString)
        {
            cmd = new SqlCommand(queryString, con);
        }
    }
}
