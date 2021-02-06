using OrderGo.Database;
using OrderGo.Login;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace OrderGo
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retreival.USER = "";
            Retreival.ROLE = "";
            LoginScreen ls = new LoginScreen();
            MainClass.showWindow(ls, this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            MainClass.showWindow(st, MDI.ActiveForm);
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["con"].ConnectionString == "")
            {
                Settings st = new Settings();
                MainClass.showWindow(st, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();
                MainClass.showWindow(ls, this);
            }
        }
    }
}
