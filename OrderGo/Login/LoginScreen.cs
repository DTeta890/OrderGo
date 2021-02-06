using OrderGo.Admin;
using OrderGo.Database;
using OrderGo.Kitchen;

namespace OrderGo.Login
{
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void userTextBox_TextChanged(object sender, System.EventArgs e)
        {
            userErrorLabel.Visible = userTextBox.Text == "" ? true : false;
        }

        private void passTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passErrorLabel.Visible = passTextBox.Text == "" ? true : false;
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if (userErrorLabel.Visible || passErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mendatory.", "error");
            else
            {
                if (Retreival.isValidUser(userTextBox.Text, passTextBox.Text))
                {
                    if (Retreival.ROLE == "Admin")
                    {
                        AdminHome ah = new AdminHome();
                        MainClass.showWindow(ah, this, MDI.ActiveForm);
                    }
                    else if (Retreival.ROLE == "Chef")
                    {
                        KitchenHome kh = new KitchenHome();
                        MainClass.showWindow(kh, this, MDI.ActiveForm);
                    }
                }
            }
        }
    }
}
