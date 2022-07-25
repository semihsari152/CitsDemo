using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitsDemo
{
    public  static class conControl
    {
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;initial catalog=Cits;integrated security=true");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

    }
}
