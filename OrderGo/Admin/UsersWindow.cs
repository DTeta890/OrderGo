using OrderGo.Database;
using OrderGo.Samples;
using System;
using System.Windows.Forms;

namespace OrderGo.Admin
{
    public partial class UsersWindow : Sample2
    {
        public UsersWindow()
        {
            InitializeComponent();
        }

        int userID;

        private void UsersWindow_Load(object sender, System.EventArgs e)
        {
            Retreival.loadItems("getRoles", rolesComboBox, "Role", "RoleID");
            rolesComboBox.SelectedIndex = -1;
        }

        private void nameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            nameErrorLabel.Visible = nameTextBox.Text == "" ? true : false;
        }

        private void phoneTextBox_TextChanged(object sender, System.EventArgs e)
        {
            phoneErrorLabel.Visible = phoneTextBox.Text == "" ? true : false;
        }

        private void addressTextBox_TextChanged(object sender, System.EventArgs e)
        {
            addressErrorLabel.Visible = addressTextBox.Text == "" ? true : false;
        }

        private void rolesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            roleErrorLabel.Visible = rolesComboBox.SelectedIndex == -1 ? true : false;
        }

        private void unameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            unameErrorLabel.Visible = unameTextBox.Text == "" ? true : false;
        }

        private void passTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passErrorLabel.Visible = passTextBox.Text == "" ? true : false;
        }

        private void usersDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = usersDataGridView.Rows[e.RowIndex];
                userID = Convert.ToInt16(row.Cells["userIDGV"].Value.ToString());
                nameTextBox.Text = row.Cells["nameGV"].Value.ToString();
                phoneTextBox.Text = row.Cells["phoneGV"].Value.ToString();
                addressTextBox.Text = row.Cells["addressGV"].Value.ToString();
                rolesComboBox.SelectedValue = row.Cells["roleIDGV"].Value;
                unameTextBox.Text = row.Cells["usernameGV"].Value.ToString();
                passTextBox.Text = row.Cells["passGV"].Value.ToString();
            }
        }

        public override void saveButton_Click(object sender, System.EventArgs e)
        {
            if (nameErrorLabel.Visible || phoneErrorLabel.Visible || addressErrorLabel.Visible || roleErrorLabel.Visible || unameErrorLabel.Visible || passErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory", "error");
            else
            {
                if (edit == 0) // Code for SAVE operation
                {
                    Insertion.insertUser(nameTextBox.Text, unameTextBox.Text, passTextBox.Text, phoneTextBox.Text, addressTextBox.Text, Convert.ToInt16(rolesComboBox.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(usersDataGridView, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGV);
                }
                else if (edit == 1) // Code for UPDATE operation
                {
                    Updation.updateUser(nameTextBox.Text, unameTextBox.Text, passTextBox.Text, phoneTextBox.Text, addressTextBox.Text, Convert.ToInt16(rolesComboBox.SelectedValue.ToString()), userID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(usersDataGridView, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGV);
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
                    Deletion.deleteData("deleteUser", "userID", userID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(usersDataGridView, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGV);
                }
            }
        }

        public override void viewButton_Click(object sender, System.EventArgs e)
        {
            Retreival.getUsers(usersDataGridView, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGV);
            searchTextBox.Enabled = true;
        }

        public override void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Retreival.searchUser(usersDataGridView, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGV, searchTextBox.Text);
        }
    }
}
