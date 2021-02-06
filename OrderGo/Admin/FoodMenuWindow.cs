using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class FoodMenuWindow : Sample2
    {
        public FoodMenuWindow()
        {
            InitializeComponent();
        }

        Int16 menuID;

        private void FoodMenuWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("getCategories", categoryComboBox, "Category", "CategoryID");
            categoryComboBox.SelectedIndex = -1;
        }

        private void menuItemTextBox_TextChanged(object sender, EventArgs e)
        {
            menuItemErrorLabel.Visible = menuItemTextBox.Text == "" ? true : false;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryErrorLabel.Visible = categoryComboBox.SelectedIndex == -1 ? true : false;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceErrorLabel.Visible = priceTextBox.Text == "" ? true : false;
        }

        private void photoTextBox_TextChanged(object sender, EventArgs e)
        {
            photoErrorLabel.Visible = photoTextBox.Text == "" ? true : false;
        }

        private void menuDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = menuDataGridView.Rows[e.RowIndex];
                menuID = Convert.ToInt16(row.Cells["menuIDGV"].Value.ToString());
                menuItemTextBox.Text = row.Cells["menuItemGV"].Value.ToString();
                categoryComboBox.SelectedValue = row.Cells["catIDGV"].Value;
                priceTextBox.Text = row.Cells["priceGV"].Value.ToString();
                photoTextBox.Text = row.Cells["photoGV"].Value.ToString();
            }
        }

        float price = 0.0f;

        public override void saveButton_Click(object sender, System.EventArgs e)
        {
            if (menuItemErrorLabel.Visible || categoryErrorLabel.Visible || priceErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory", "error");
            else
            {
                if (edit == 0) // Code for SAVE operation
                {
                    if (Single.TryParse(priceTextBox.Text, out price))
                    {
                        Insertion.insertMenu(menuItemTextBox.Text, price, Convert.ToInt16(categoryComboBox.SelectedValue.ToString()), photoTextBox.Text);
                        MainClass.resetDisable(leftPanel);
                        Retreival.getMenu(menuDataGridView, menuIDGV, menuItemGV, priceGV, photoGV, categoryGV, catIDGV);
                    }
                    else
                        MainClass.showMessage("Price not valid.", "error");
                }
                else if (edit == 1) // Code for UPDATE operation
                {
                    if (Single.TryParse(priceTextBox.Text, out price))
                    {
                        Updation.updateMenu(menuItemTextBox.Text, price, Convert.ToInt16(categoryComboBox.SelectedValue.ToString()), photoTextBox.Text, menuID);
                        MainClass.resetDisable(leftPanel);
                        Retreival.getMenu(menuDataGridView, menuIDGV, menuItemGV, priceGV, photoGV, categoryGV, catIDGV);
                    }
                    else
                        MainClass.showMessage("Price not valid.", "error");
                }
            }
        }

        public override void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("deleteMenu", "menuID", menuID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getMenu(menuDataGridView, menuIDGV, menuItemGV, priceGV, photoGV, categoryGV, catIDGV);
                }
            }
        }

        public override void viewButton_Click(object sender, System.EventArgs e)
        {
            Retreival.getMenu(menuDataGridView, menuIDGV, menuItemGV, priceGV, photoGV, categoryGV, catIDGV);
            searchTextBox.Enabled = true;
        }

        public override void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Retreival.searchMenu(menuDataGridView, menuIDGV, menuItemGV, priceGV, categoryGV, catIDGV, searchTextBox.Text);
        }
    }
}
