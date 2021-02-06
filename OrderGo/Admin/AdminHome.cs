using System;

namespace OrderGo.Admin
{
    public partial class AdminHome : Sample
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void rolesButton_Click(object sender, System.EventArgs e)
        {
            RolesWindow rw = new RolesWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void usersButton_Click(object sender, System.EventArgs e)
        {
            UsersWindow uw = new UsersWindow();
            MainClass.showWindow(uw, this, MDI.ActiveForm);
        }

        private void foodCategoryButton_Click(object sender, System.EventArgs e)
        {
            FoodCategoriesWindow fcw = new FoodCategoriesWindow();
            MainClass.showWindow(fcw, this, MDI.ActiveForm);
        }

        private void foodMenuButton_Click(object sender, System.EventArgs e)
        {
            FoodMenuWindow fmw = new FoodMenuWindow();
            MainClass.showWindow(fmw, this, MDI.ActiveForm);
        }

        private void ordersButton_Click(object sender, System.EventArgs e)
        {
            AdminOrdersWindow aow = new AdminOrdersWindow();
            MainClass.showWindow(aow, this, MDI.ActiveForm);
        }

        private void billGeneratorButton_Click(object sender, System.EventArgs e)
        {
            BillGeneratorWindow bg = new BillGeneratorWindow();
            MainClass.showWindow(bg, this, MDI.ActiveForm);
        }

        private void taxManagementButton_Click(object sender, System.EventArgs e)
        {
            TaxManagementWindow tm = new TaxManagementWindow();
            MainClass.showWindow(tm, this, MDI.ActiveForm);
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            FinanceWindow fw = new FinanceWindow();
            MainClass.showWindow(fw, this, MDI.ActiveForm);
        }
    }
}
