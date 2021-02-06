using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Kitchen
{
    public partial class KitchenOrdersWindow : Sample2
    {
        public KitchenOrdersWindow()
        {
            InitializeComponent();
        }

        private void KitchenOrdersWindow_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
            addButton.Visible = false;
            editButton.Visible = false;
            saveButton.Visible = false;
            deleteButton.Visible = false;
            viewButton.Visible = false;
            groupBoxSearch.Visible = false;
            searchTextBox.Visible = false;
        }

        public override void backButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            KitchenHome kh = new KitchenHome();
            MainClass.showWindow(kh, MDI.ActiveForm);
        }

        Int64 orderID;

        private void ordersDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = ordersDataGridView.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                Retreival.getOrderDetails(orderID, orderDetailsDataGridView, itemNameGV, quantityGV);
                MainClass.sno(orderDetailsDataGridView, "snoGV1");
                if (e.ColumnIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation.updateOrderStatus(1, orderID);
                        Retreival.getPendingOrders(ordersDataGridView, orderIDGV, statusGV);
                        MainClass.sno(ordersDataGridView, "snoGV");
                        orderDetailsDataGridView.DataSource = null;
                    }
                }
            }
        }

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                Retreival.getPendingOrders(ordersDataGridView, orderIDGV, statusGV);
                MainClass.sno(ordersDataGridView, "snoGV");
                count = 0;
            }
        }

        private void KitchenOrdersWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void loadOrdersButton_Click(object sender, EventArgs e)
        {
            Retreival.getPendingOrders(ordersDataGridView, orderIDGV, statusGV);
            MainClass.sno(ordersDataGridView, "snoGV");
        }
    }
}
