using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConnectionFactory
    {
        public static IDbConnection GetConnection()
        {
            var con = new SqlConnection("connectionString");
            con.Open();
            return con;
        }
    }
}
