using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace OrderGo.Database
{
    class Updation
    {
        public static void updateRole(string role, Int16 roleID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateRole", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", role);
                cmd.Parameters.AddWithValue("rid", roleID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(role + " updated successfully into the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void updateUser(string name, string uname, string pass, string phone, string address, Int16 roleID, int userID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateUser", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("username", uname);
                cmd.Parameters.AddWithValue("password", pass);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("roleID", roleID);
                cmd.Parameters.AddWithValue("userID", userID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(name + " updated successfully into the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void updateCategory(string category, Int16 categoryID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateCategory", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", category);
                cmd.Parameters.AddWithValue("cid", categoryID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(category + " updated successfully into the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void updateMenu(string menuItem, float price, Int16 catID, string photo, Int16 menuID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateMenu", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", menuItem);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("catID", catID);
                cmd.Parameters.AddWithValue("photo", photo);
                cmd.Parameters.AddWithValue("menuID", menuID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(menuItem + " updated successfully into the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void updateOrderStatus(Int16 status, Int64 orderID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateOrderStatus", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("oid", orderID);
                DbConnection.con.Open();
                cmd.ExecuteNonQuery();
                DbConnection.con.Close();
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void updateTax(string tName, float tAmount, Int16 taxID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateTax", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", tName);
                cmd.Parameters.AddWithValue("amount", tAmount);
                cmd.Parameters.AddWithValue("tid", taxID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(tName + " updated successfully into the system", "success");
            }
            catch (System.Exception ex)
            {
                DbConnection.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
    }
}
