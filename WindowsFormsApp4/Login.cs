using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Login : Form
    {

        string currentAccountNum; //Placeholder for testing, remove default account number later
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

        public void verifyLogin()
        {
            if (accountInput.Text == "" || pinInput.Text == "")
            {
                MessageBox.Show("Please enter an account number and PIN.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (checkLoginDetails() == false)
            {
                MessageBox.Show("Incorrect Account Number or PIN. Please try again.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string loggedInAccount = currentAccountNum.ToString();
                accountDetails accountDetails = new accountDetails(loggedInAccount);
                MessageBox.Show("Successfully logged in!",
                                     "Details Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                accountDetails.Show();
            }            
        } 

        private bool checkLoginDetails()
        {
            bool isValid = accountsDbConnection.checkCredentials(accountInput.Text, pinInput.Text);
            return isValid;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            currentAccountNum = accountInput.Text.ToString();
            verifyLogin();
        }
    }
}
