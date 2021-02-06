using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class RolesWindow : Sample2
    {
        public RolesWindow()
        {
            InitializeComponent();
        }

        Int16 roleID;

        private void roleTextBox_TextChanged(object sender, System.EventArgs e)
        {
            roleErrorLabel.Visible = roleTextBox.Text == "" ? true : false;
        }

        private void rolesDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = rolesDataGridView.Rows[e.RowIndex];
                roleID = Convert.ToInt16(row.Cells["roleIDGV"].Value.ToString());
                roleTextBox.Text = row.Cells["roleNameGV"].Value.ToString();
            }
        }

        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (roleErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory", "error");
            else
            {
                if (edit == 0) // Code for SAVE operation
                {
                    Insertion.insertRole(roleTextBox.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(rolesDataGridView, roleIDGV, roleNameGV);
                }
                else if (edit == 1) // Code for UPDATE operation
                {
                    Updation.updateRole(roleTextBox.Text, roleID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(rolesDataGridView, roleIDGV, roleNameGV);
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
                    Deletion.deleteData("deleteRole", "rid", roleID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(rolesDataGridView, roleIDGV, roleNameGV);
                }
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            Retreival.getRoles(rolesDataGridView, roleIDGV, roleNameGV);
            searchTextBox.Enabled = true;
        }

        public override void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Retreival.searchRole(rolesDataGridView, roleIDGV, roleNameGV, searchTextBox.Text);
        }
    }
}
