using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Xml;

namespace OrderGo.Login
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void serverTextBox_TextChanged(object sender, System.EventArgs e)
        {
            serverErrorLabel.Visible = serverTextBox.Text == "" ? true : false;
        }

        private void dbTextBox_TextChanged(object sender, System.EventArgs e)
        {
            dbErrorLabel.Visible = dbTextBox.Text == "" ? true : false;
        }

        private void userIdTextBox_TextChanged(object sender, System.EventArgs e)
        {
            userIdErrorLabel.Visible = userIdTextBox.Text == "" ? true : false;
        }

        private void saveConnection(string con)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                    xElement.FirstChild.Attributes[2].Value = con;
            }
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (serverErrorLabel.Visible || dbErrorLabel.Visible || userIdErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mandatory.", "error");
            else
            {
                try
                {
                    string path = $"server={serverTextBox.Text};userid={userIdTextBox.Text};password={passTextBox.Text};database={dbTextBox.Text}";
                    MySqlConnection conTest = new MySqlConnection(path);
                    conTest.Open();
                    MainClass.showMessage("Connection to server was succesfull.", "success");
                    conTest.Close();
                    saveButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MainClass.showMessage(ex.Message, "error");
                }
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (serverErrorLabel.Visible || dbErrorLabel.Visible || userIdErrorLabel.Visible)
                MainClass.showMessage("Fields with * are mandatory.", "error");
            else
            {
                string connection = $"server={serverTextBox.Text};userid={userIdTextBox.Text};password={passTextBox.Text};database={dbTextBox.Text}";
                saveConnection(connection);
                MainClass.showMessage("Settings saved successfully.", "success");
                LoginScreen ls = new LoginScreen();
                MainClass.showWindow(ls, this, MDI.ActiveForm);
            }
        }
    }
}
