using System;

namespace OrderGo.Kitchen
{
    public partial class KitchenHome : Sample
    {
        public KitchenHome()
        {
            InitializeComponent();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            KitchenOrdersWindow ko = new KitchenOrdersWindow();
            MainClass.showWindow(ko, this, MDI.ActiveForm);
        }
    }
}
