using CrystalDecisions.CrystalReports.Engine;
using OrderGo.Database;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class BillGeneratorWindow : Sample
    {
        public BillGeneratorWindow()
        {
            InitializeComponent();
        }

        ReportDocument rd;

        private void BillGeneratorWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            MainClass.showWindow(ah, MDI.ActiveForm);
        }

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                Retreival.getCompletedOrders(ordersDataGridView, orderIDGV, statusGV, totalAmountGV, orderTypeGV, phoneGV, addressGV, taxGV);
                MainClass.sno(ordersDataGridView, "snoGV");
                count = 0;
            }
        }

        private void BillGeneratorWindow_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            timer1.Stop();
            if (rd != null)
                rd.Close();
        }

        private void loadOrdersButton_Click(object sender, EventArgs e)
        {
            Retreival.getCompletedOrders(ordersDataGridView, orderIDGV, statusGV, totalAmountGV, orderTypeGV, phoneGV, addressGV, taxGV);
            MainClass.sno(ordersDataGridView, "snoGV");
        }

        Int64 orderID;
        Int16 orderType;
        float amtReturn = 0.0f;

        private void ordersDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                amtPaidTextBox.Text = "0.0";
                amtReturnedTextBox.Text = "0.0";
                DataGridViewRow row = ordersDataGridView.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                orderType = Convert.ToInt16(row.Cells["orderTypeGV"].Value.ToString());
                Retreival.getOrderDetails(orderID, orderDetailsDataGridView, itemNameGV, quantityGV);
                MainClass.sno(orderDetailsDataGridView, "snoGV1");
                totalBillLabel.Text = row.Cells["totalAmountGV"].Value.ToString();
                phoneTextBox.Text = row.Cells["phoneGV"].Value.ToString();
                addressTextBox.Text = row.Cells["addressGV"].Value.ToString();
                taxTextBox.Text = row.Cells["taxGV"].Value.ToString();
                if (Convert.ToInt16(row.Cells["orderTypeGV"].Value.ToString()) == 0)
                {
                    amtPaidTextBox.Enabled = true;
                    getButton.Enabled = true;
                }
                else
                {
                    amtPaidTextBox.Enabled = false;
                    getButton.Enabled = false;
                }
            }
        }

        private void amtPaidTextBox_TextChanged(object sender, EventArgs e)
        {
            amtPaidErrorLabel.Visible = amtPaidTextBox.Text == "" ? true : false;
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if (totalBillLabel.Text == "0.0")
                MainClass.showMessage("Please choose an order.", "error");
            else if (amtPaidTextBox.Text == "")
                MainClass.showMessage("Invalid paid amount.", "error");
            else
            {
                try
                {
                    float amtPaid = Convert.ToSingle(amtPaidTextBox.Text);
                    float total = Convert.ToSingle(totalBillLabel.Text);
                    if (amtPaid >= total)
                    {
                        amtReturn = amtPaid - total;
                        amtReturnedTextBox.Text = amtReturn.ToString();
                    }
                    else
                    {
                        MainClass.showMessage("Invalid paid amount.", "error");
                        amtReturnedTextBox.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MainClass.showMessage(ex.Message, "error");
                }
            }
        }

        private void generateBillButton_Click(object sender, EventArgs e)
        {
            if (orderType == 0)
            {
                if (totalBillLabel.Text == "0.0")
                    MainClass.showMessage("Please choose an order.", "error");
                else if (amtPaidErrorLabel.Visible)
                    MainClass.showMessage("Fields with * are mendatory.", "error");
                else if (amtReturnedTextBox.Text == "")
                    MainClass.showMessage("Invalid paid amount.", "error");
                else
                {
                    Updation.updateOrderStatus(2, orderID);
                    Retreival.getCompletedOrders(ordersDataGridView, orderIDGV, statusGV, totalAmountGV, orderTypeGV, phoneGV, addressGV, taxGV);
                    MainClass.sno(ordersDataGridView, "snoGV");
                    orderDetailsDataGridView.DataSource = null;
                    MainClass.showMessage("Order Completed Successfully...", "success");
                    rd = new ReportDocument();
                    Retreival.getDineInOrderReport(billCrystalReportViewer, rd, orderID);
                    amtPaidTextBox.Text = "0.0";
                    amtPaidTextBox.Enabled = false;
                    amtReturnedTextBox.Text = "0.0";
                    getButton.Enabled = false;
                    totalBillLabel.Text = "0.0";
                }
            }
            else if (orderType == 1)
            {
                if (totalBillLabel.Text == "0.0")
                    MainClass.showMessage("Please choose an order.", "error");
                else
                {
                    Updation.updateOrderStatus(2, orderID);
                    Retreival.getCompletedOrders(ordersDataGridView, orderIDGV, statusGV, totalAmountGV, orderTypeGV, phoneGV, addressGV, taxGV);
                    MainClass.sno(ordersDataGridView, "snoGV");
                    orderDetailsDataGridView.DataSource = null;
                    MainClass.showMessage("Order Completed Successfully...", "success");
                    rd = new ReportDocument();
                    Retreival.getDeliveryOrderReport(billCrystalReportViewer, rd, orderID);
                    totalBillLabel.Text = "0.0";
                    phoneTextBox.Clear();
                    addressTextBox.Clear();
                    taxTextBox.Clear();
                }
            }
        }
    }
}
