using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class FoodCategoriesWindow : Sample2
    {
        public FoodCategoriesWindow()
        {
            InitializeComponent();
        }

        Int16 categoryID;

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            categoryErrorLabel.Visible = categoryTextBox.Text == "" ? true : false;
        }

        private void categoryDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = categoryDataGridView.Rows[e.RowIndex];
                categoryID = Convert.ToInt16(row.Cells["categoryIDGV"].Value.ToString());
                categoryTextBox.Text = row.Cells["categoryNameGV"].Value.ToString();
            }
        }
        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (categoryErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory", "error");
            else
            {
                if (edit == 0) // Code for SAVE operation
                {
                    Insertion.insertCategory(categoryTextBox.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(categoryDataGridView, categoryIDGV, categoryNameGV);
                }
                else if (edit == 1) // Code for UPDATE operation
                {
                    Updation.updateCategory(categoryTextBox.Text, categoryID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(categoryDataGridView, categoryIDGV, categoryNameGV);
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
                    Deletion.deleteData("deleteCategory", "cid", categoryID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategories(categoryDataGridView, categoryIDGV, categoryNameGV);
                }
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            Retreival.getCategories(categoryDataGridView, categoryIDGV, categoryNameGV);
            searchTextBox.Enabled = true;
        }

        public override void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Retreival.searchCategory(categoryDataGridView, categoryIDGV, categoryNameGV, searchTextBox.Text);
        }
    }
}
