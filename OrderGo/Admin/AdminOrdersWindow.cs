using MySql.Data.MySqlClient;
using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class AdminOrdersWindow : Sample2
    {
        public AdminOrdersWindow()
        {
            InitializeComponent();
        }

        float totalAmount = 0.0f;
        float tax = 0.0f;

        private void AdminOrdersWindow_Load(object sender, System.EventArgs e)
        {
            Retreival.loadItems("getCategories", categoryComboBox, "Category", "CategoryID");
            categoryComboBox.SelectedIndex = -1;
            Retreival.loadItems("getTaxes", taxComboBox, "Amount", "Tax ID");
            taxComboBox.SelectedIndex = -1;
            editButton.Visible = false;
            deleteButton.Visible = false;
            viewButton.Visible = false;
            groupBoxSearch.Visible = false;
            searchTextBox.Visible = false;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
            {
                Retreival.loadItems("getItemsByCategory", itemComboBox, "Menu Item", "MenuID", "cid", Convert.ToInt32(categoryComboBox.SelectedValue.ToString()));
                categoryErrorLabel.Visible = false;
                itemComboBox.SelectedIndex = -1;
                quantityUpDown.Value = 0;
            }
            else
                categoryErrorLabel.Visible = true;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedIndex != -1)
            {
                quantityUpDown.Value = 1;
                itemErrorLabel.Visible = false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand("getPriceByItem", DbConnection.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("mid", Convert.ToInt32(itemComboBox.SelectedValue.ToString()));
                    DbConnection.con.Open();
                    priceTextBox.Text = cmd.ExecuteScalar().ToString();
                    DbConnection.con.Close();
                }
                catch (System.Exception ex)
                {
                    DbConnection.con.Close();
                    MainClass.showMessage(ex.Message, "error");
                }
            }
            else
            {
                itemErrorLabel.Visible = true;
                priceTextBox.Text = "";
                priceTextBox.Enabled = false;
            }
        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            quantityErrorLabel.Visible = Convert.ToInt32(quantityUpDown.Value.ToString()) == 0 ? true : false;
        }

        private void orderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderTypeComboBox.SelectedIndex != -1)
            {
                orderTypeErrorLabel.Visible = false;
                taxComboBox.Enabled = false;
                if (orderTypeComboBox.SelectedIndex == 0)
                {
                    phoneTextBox.Clear();
                    phoneTextBox.Enabled = false;
                    phoneErrorLabel.Visible = false;
                    addressTextBox.Clear();
                    addressTextBox.Enabled = false;
                    addressErrorLabel.Visible = false;
                    taxComboBox.SelectedIndex = 0;
                }
                else if (orderTypeComboBox.SelectedIndex == 1)
                {
                    phoneTextBox.Clear();
                    phoneTextBox.Enabled = true;
                    phoneErrorLabel.Visible = true;
                    addressTextBox.Clear();
                    addressTextBox.Enabled = true;
                    addressErrorLabel.Visible = true;
                    taxComboBox.SelectedIndex = 1;
                }
                tax = Convert.ToSingle(taxComboBox.Text);
                totalAmount = tax;
                totalAmountLabel.Text = totalAmount.ToString();
            }
            else
                orderTypeErrorLabel.Visible = true;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneErrorLabel.Visible = phoneTextBox.Text == "" ? true : false;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressErrorLabel.Visible = addressTextBox.Text == "" ? true : false;
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 10)
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to delete this item ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DataGridViewRow row = orderDataGridView.Rows[e.RowIndex];
                        float price = Convert.ToSingle(row.Cells["priceGV"].Value.ToString());
                        int quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                        totalAmount -= (price * quantity);
                        totalAmountLabel.Text = totalAmount.ToString();
                        orderDataGridView.Rows.Remove(row);
                        MainClass.sno(orderDataGridView, "snoGV");
                    }
                }
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (!orderTypeErrorLabel.Visible)
            {
                if (orderTypeComboBox.SelectedItem.ToString() == "Dine-In")
                {
                    if (categoryErrorLabel.Visible || itemErrorLabel.Visible || quantityErrorLabel.Visible)
                        MainClass.showMessage("Fields with * are mendatory.", "error");
                    else
                    {
                        bool check = false;
                        foreach (DataGridViewRow row in orderDataGridView.Rows)
                        {
                            if (row.Cells["itemIDGV"].Value.ToString() == itemComboBox.SelectedValue.ToString())
                            {
                                MainClass.showMessage("Item already exists.", "error");
                                check = true;
                                break;
                            }
                        }
                        if (!check)
                        {
                            totalAmount += (Convert.ToSingle(priceTextBox.Text) * Convert.ToInt16(quantityUpDown.Value));
                            totalAmountLabel.Text = totalAmount.ToString();
                            DataRowView drvCategory = categoryComboBox.SelectedItem as DataRowView;
                            DataRowView drvItem = itemComboBox.SelectedItem as DataRowView;
                            orderDataGridView.Rows.Add(
                                null,
                                Convert.ToInt16(categoryComboBox.SelectedValue),
                                drvCategory["Category"],
                                Convert.ToInt32(itemComboBox.SelectedValue),
                                drvItem["Menu Item"],
                                Convert.ToDecimal(priceTextBox.Text),
                                Convert.ToInt16(quantityUpDown.Value),
                                orderTypeComboBox.SelectedItem.ToString(),
                                null, null,
                                "Remove"
                            );
                        }
                    }
                }
                else if (orderTypeComboBox.SelectedItem.ToString() == "Home-Delivery")
                {
                    if (categoryErrorLabel.Visible || itemErrorLabel.Visible || quantityErrorLabel.Visible || phoneErrorLabel.Visible || addressErrorLabel.Visible)
                        MainClass.showMessage("Fields with * are mendatory.", "error");
                    else
                    {
                        bool check = false;
                        foreach (DataGridViewRow row in orderDataGridView.Rows)
                        {
                            if (row.Cells["itemIDGV"].Value.ToString() == itemComboBox.SelectedValue.ToString())
                            {
                                MainClass.showMessage("Item already exists.", "error");
                                check = true;
                                break;
                            }
                        }
                        if (!check)
                        {
                            totalAmount += (Convert.ToSingle(priceTextBox.Text) * Convert.ToInt16(quantityUpDown.Value));
                            totalAmountLabel.Text = totalAmount.ToString();
                            DataRowView drvCategory = categoryComboBox.SelectedItem as DataRowView;
                            DataRowView drvItem = itemComboBox.SelectedItem as DataRowView;
                            orderDataGridView.Rows.Add(
                                null,
                                Convert.ToInt16(categoryComboBox.SelectedValue),
                                drvCategory["Category"],
                                Convert.ToInt32(itemComboBox.SelectedValue),
                                drvItem["Menu Item"],
                                Convert.ToDecimal(priceTextBox.Text),
                                Convert.ToInt16(quantityUpDown.Value),
                                orderTypeComboBox.SelectedItem.ToString(),
                                phoneTextBox.Text,
                                addressTextBox.Text,
                                "Remove"
                            );
                        }
                    }
                }
                MainClass.sno(orderDataGridView, "snoGV");
                orderTypeComboBox.Enabled = false;
                phoneTextBox.Enabled = false;
                addressTextBox.Enabled = false;
            }
            else
                MainClass.showMessage("Fields with * are mendatory.", "error");
        }

        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.Rows.Count > 0)
            {
                // Protects the data because we are using two tables. If error uses rollback
                using (TransactionScope ts = new TransactionScope())
                {
                    try
                    {
                        if (orderTypeComboBox.SelectedItem.ToString() == "Dine-In")
                            Insertion.insertOrder(Convert.ToInt16(orderTypeComboBox.SelectedIndex), totalAmount, 0, null, null, tax);
                        else if (orderTypeComboBox.SelectedItem.ToString() == "Home-Delivery")
                            Insertion.insertOrder(Convert.ToInt16(orderTypeComboBox.SelectedIndex), totalAmount, 0, phoneTextBox.Text, addressTextBox.Text, tax);
                        Int64 orderID = Retreival.getLastOrderID();
                        foreach (DataGridViewRow row in orderDataGridView.Rows)
                            Insertion.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["itemIDGV"].Value.ToString()), Convert.ToInt16(row.Cells["quantityGV"].Value.ToString()));
                        MainClass.showMessage("Order Placed", "success");
                    }
                    catch (Exception ex)
                    {
                        MainClass.showMessage(ex.Message, "error");
                    }
                    ts.Complete();
                    orderDataGridView.Rows.Clear();
                    orderDataGridView.Refresh();
                    totalAmount = 0.0f;
                    tax = 0.0f;
                    totalAmountLabel.Text = "0.0";
                    MainClass.resetDisable(leftPanel);
                }
            }
            else
                MainClass.showMessage("Nothing selected from menu.", "error");
        }
    }
}
