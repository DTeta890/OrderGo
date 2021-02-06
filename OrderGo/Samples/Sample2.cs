using OrderGo.Admin;

namespace OrderGo.Samples
{
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public virtual void backButton_Click(object sender, System.EventArgs e)
        {
            AdminHome ah = new AdminHome();
            MainClass.showWindow(ah, MDI.ActiveForm);
        }

        public static int edit = 0;
        public static int delStatus = 0;

        public virtual void addButton_Click(object sender, System.EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(leftPanel);
            delStatus = 0;
        }

        public virtual void editButton_Click(object sender, System.EventArgs e)
        {
            edit = 1;
            MainClass.EnableControls(leftPanel);
        }

        public virtual void saveButton_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void deleteButton_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void viewButton_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
