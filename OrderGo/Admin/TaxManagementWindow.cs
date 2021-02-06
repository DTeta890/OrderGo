using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class TaxManagementWindow : Sample2
    {
        public TaxManagementWindow()
        {
            InitializeComponent();
        }

        Int16 taxID;

        private void taxNameTextBox_TextChanged(object sender, EventArgs e)
        {
            taxNameErrorLabel.Visible = taxNameTextBox.Text == "" ? true : false;
        }

        private void taxAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            taxAmountErrorLabel.Visible = taxAmountTextBox.Text == "" ? true : false;
        }

        private void taxesDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = taxesDataGridView.Rows[e.RowIndex];
                taxID = Convert.ToInt16(row.Cells["taxIDGV"].Value.ToString());
                taxNameTextBox.Text = row.Cells["taxNameGV"].Value.ToString();
                taxAmountTextBox.Text = row.Cells["taxAmountGV"].Value.ToString();
            }
        }

        float tAmount = 0.0f;

        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (taxNameErrorLabel.Visible || taxAmountErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory", "error");
            else
            {
                if (edit == 0) // Code for SAVE operation
                {
                    if (Single.TryParse(taxAmountTextBox.Text, out tAmount))
                    {
                        Insertion.insertTax(taxNameTextBox.Text, tAmount);
                        MainClass.resetDisable(leftPanel);
                        Retreival.getTaxes(taxesDataGridView, taxIDGV, taxNameGV, taxAmountGV);
                    }
                    else
                        MainClass.showMessage("Invalid amount.", "error");
                }
                else if (edit == 1) // Code for UPDATE operation
                {
                    if (Single.TryParse(taxAmountTextBox.Text, out tAmount))
                    {
                        Updation.updateTax(taxNameTextBox.Text, tAmount, taxID);
                        MainClass.resetDisable(leftPanel);
                        Retreival.getTaxes(taxesDataGridView, taxIDGV, taxNameGV, taxAmountGV);
                    }
                    else
                        MainClass.showMessage("Invalid amount.", "error");
                }
            }
        }

        public override void deleteButton_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("deleteTax", "tid", taxID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTaxes(taxesDataGridView, taxIDGV, taxNameGV, taxAmountGV);
                }
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            Retreival.getTaxes(taxesDataGridView, taxIDGV, taxNameGV, taxAmountGV);
            searchTextBox.Enabled = true;
        }

        public override void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Retreival.searchTax(taxesDataGridView, taxIDGV, taxNameGV, taxAmountGV, searchTextBox.Text);
        }
    }
}
