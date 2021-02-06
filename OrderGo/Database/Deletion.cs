using MySql.Data.MySqlClient;
using System.Data;

namespace OrderGo.Database
{
    class Deletion
    {
        public static void deleteData(string procedure, string param, int value)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(procedure, DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, value);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage("Data deleted successfully from the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
    }
}
