using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OrderGo.Database
{
    class Insertion
    {
        public static void insertRole(string role)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertRole", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", role);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(role + " added successfully into the system", "success");
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible Error:\nRole may exist already.", "error");
            }
        }
        public static void insertUser(string name, string uname, string pass, string phone, string address, Int16 roleID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertUser", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("username", uname);
                cmd.Parameters.AddWithValue("password", pass);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("roleID", roleID);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(name + " added successfully into the system", "success");
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to save user.\nPossible Error:\nUser may exist already.", "error");
            }
        }
        public static void insertCategory(string category)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertCategory", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", category);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(category + " added successfully into the system", "success");
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to save category.\nPossible Error:\nCategory may exist already.", "error");
            }
        }
        public static void insertMenu(string menuItem, float price,  Int16 catID, string photo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertMenu", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", menuItem);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("catID", catID);
                cmd.Parameters.AddWithValue("photo", photo);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(menuItem + " added successfully into the system", "success");
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to save menu item.\nPossible Error:\nMenu item may exist already.", "error");
            }
        }
        public static void insertOrder(Int16 orderType, float totalAmount, Int16 status, string phone, string address, float tax)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertOrder", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("date", DateTime.Today);
                cmd.Parameters.AddWithValue("orderType", orderType);
                cmd.Parameters.AddWithValue("tAmount", totalAmount);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("tax", tax);
                DbConnection.con.Open();
                cmd.ExecuteNonQuery();
                DbConnection.con.Close();
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to place order.", "error");
            }
        }
        public static void insertOrderDetails(Int64 orderID, int itemID, Int16 quantity)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertOrderDetails", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", orderID);
                cmd.Parameters.AddWithValue("itemID", itemID);
                cmd.Parameters.AddWithValue("quantity", quantity);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to add order details.", "error");
            }
        }
        public static void insertTax(string tName, float tAmount)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertTax", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", tName);
                cmd.Parameters.AddWithValue("amount", tAmount);
                DbConnection.con.Open();
                int res = cmd.ExecuteNonQuery();
                DbConnection.con.Close();
                if (res > 0)
                    MainClass.showMessage(tName + " added successfully into the system", "success");
            }
            catch (System.Exception)
            {
                DbConnection.con.Close();
                MainClass.showMessage("Unable to save tax.\nPossible Error:\nTax may exist already.", "error");
            }
        }
    }
}
