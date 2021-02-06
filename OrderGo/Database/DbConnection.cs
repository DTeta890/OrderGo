using MySql.Data.MySqlClient;
using System.Configuration;

namespace OrderGo
{
    class DbConnection
    {
        private static string _path = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static MySqlConnection con = new MySqlConnection(_path);
    }
}