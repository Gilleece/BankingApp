using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Login : Form
    {

        int currentAccountNum = 23256612; //Placeholder for testing, remove default account number later
        int inputPin;
        bool loggedIn = false; 

        public dbConnector accountsDbConnection = new dbConnector(@"accounts.db");

        public Login()
        {
            if (File.Exists("accounts.db"))
            {
                InitializeComponent();
                getAccounts();
            }
            else
            {
                var confirmUpdate = MessageBox.Show("The database is missing.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getAccounts()
        {
            DataTable accountsDT = accountsDbConnection.FetchMessageDataFromTable();
            dataGridView1.DataSource = accountsDT;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            accountDetails accountDetails = new accountDetails();
            accountDetails.Show();
        }
    }
}
