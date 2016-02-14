using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharp_MySQL_CRUDwithImage.App_data
{
    class connectionManager
    {
        internal static string connectionString = "host=192.168.0.91; database=c#1; user=test1; password=test1";

        internal static MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
