using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OrderGo.Database
{
    class Retreival
    {
        public static void getPendingOrders(DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn statusGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getPendingOrders", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["Order ID"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getCompletedOrders(DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn statusGV, DataGridViewColumn totalAmountGV, DataGridViewColumn orderTypeGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn taxGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getCompletedOrders", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["Order ID"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                orderTypeGV.DataPropertyName = dt.Columns["Order Type"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                taxGV.DataPropertyName = dt.Columns["Tax"].ToString();
                gv.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getOrderDetails(Int64 orderID, DataGridView gv, DataGridViewColumn itemNameGV, DataGridViewColumn quantityGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getOrderDetails", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", orderID);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemNameGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getRoles(DataGridView gv, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getRoles", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void searchRole(DataGridView gv, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV, string rname)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("searchRole", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rname", rname);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getCategories(DataGridView gv, DataGridViewColumn categoryIDGV, DataGridViewColumn categoryNameGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getCategories", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categoryIDGV.DataPropertyName = dt.Columns["CategoryID"].ToString();
                categoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void searchCategory(DataGridView gv, DataGridViewColumn categoryIDGV, DataGridViewColumn categoryNameGV, string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("searchCategory", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categoryIDGV.DataPropertyName = dt.Columns["CategoryID"].ToString();
                categoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getMenu(DataGridView gv, DataGridViewColumn menuIDGV, DataGridViewColumn menuItemGV, DataGridViewColumn priceGV, DataGridViewColumn photoGV, DataGridViewColumn categoryGV, DataGridViewColumn catIDGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getMenu", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                menuIDGV.DataPropertyName = dt.Columns["MenuID"].ToString();
                menuItemGV.DataPropertyName = dt.Columns["Menu Item"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                photoGV.DataPropertyName = dt.Columns["Photo"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["CategoryID"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void searchMenu(DataGridView gv, DataGridViewColumn menuIDGV, DataGridViewColumn menuItemGV, DataGridViewColumn priceGV, DataGridViewColumn categoryGV, DataGridViewColumn catIDGV, string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("searchMenu", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                menuIDGV.DataPropertyName = dt.Columns["MenuID"].ToString();
                menuItemGV.DataPropertyName = dt.Columns["Menu Item"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["CategoryID"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getDineInOrderReport(CrystalReportViewer crv, ReportDocument rd, Int64 orderID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getDineInOrderReport", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", orderID);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\dineInOrderReport.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
                PrintDialog printDialog = new PrintDialog();
                rd.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                rd.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
            catch (System.Exception ex)
            {
                if (rd != null)
                    rd.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getDeliveryOrderReport(CrystalReportViewer crv, ReportDocument rd, Int64 orderID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getDeliveryOrderReport", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", orderID);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\deliveryOrderReport.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
                PrintDialog printDialog = new PrintDialog();
                rd.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                rd.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
            catch (System.Exception ex)
            {
                if (rd != null)
                    rd.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getTaxes(DataGridView gv, DataGridViewColumn taxIDGV, DataGridViewColumn taxNameGV, DataGridViewColumn taxAmountGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getTaxes", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                taxIDGV.DataPropertyName = dt.Columns["Tax ID"].ToString();
                taxNameGV.DataPropertyName = dt.Columns["Name"].ToString();
                taxAmountGV.DataPropertyName = dt.Columns["Amount"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void searchTax(DataGridView gv, DataGridViewColumn taxIDGV, DataGridViewColumn taxNameGV, DataGridViewColumn taxAmountGV, string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("searchTax", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                taxIDGV.DataPropertyName = dt.Columns["Tax ID"].ToString();
                taxNameGV.DataPropertyName = dt.Columns["Name"].ToString();
                taxAmountGV.DataPropertyName = dt.Columns["Amount"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getFinance(DataGridView gv, DataGridViewColumn dateGV, DataGridViewColumn typeGV, DataGridViewColumn totalGV, Label count, string fromD, string toD)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getFinance", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("fromD", fromD);
                cmd.Parameters.AddWithValue("toD", toD);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                typeGV.DataPropertyName = dt.Columns["Order Type"].ToString();
                totalGV.DataPropertyName = dt.Columns["Total"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
                count.Text = dt.Rows.Count.ToString();
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static Int64 getLastOrderID()
        {
            Int64 orderID = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("getLastOrderID", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                DbConnection.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                DbConnection.con.Close();
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
            return orderID;
        }
        public static void getUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("getUsers", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["User"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void searchUser(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV, string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("searchUser", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", name);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["User"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        private static string _name;
        private static string _role;
        public static string USER
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public static string ROLE
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }
        public static bool isValidUser(string uname, string pass)
        {
            bool status = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand("getUserForAuth", DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", uname);
                cmd.Parameters.AddWithValue("password", pass);
                DbConnection.con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (uname == dr["Username"].ToString() && pass == dr["Password"].ToString())
                        {
                            USER = dr["User"].ToString();
                            ROLE = dr["Role"].ToString();
                            status = true;
                        }
                        else
                        {
                            MainClass.showMessage("Invalid credentials.", "error");
                            status = false;
                        }
                    }
                }
                else
                {
                    MainClass.showMessage("Invalid credentials.", "error");
                    status = false;
                }
                DbConnection.con.Close();
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
            return status;
        }
        public static void loadItems(string procedure, ComboBox cb, string dMember, string vMember, string param = null, int value = 0)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(procedure, DbConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null && value != 0)
                    cmd.Parameters.AddWithValue(param, value);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
    }
}
