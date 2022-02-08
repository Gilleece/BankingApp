using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace BankingApp
{
    public partial class Login : Form
    {       

        public dbConnector accountsDbConnection = new dbConnector(@"accounts.db");

        public Login()
        {
            if (File.Exists("accounts.db"))
            {
                InitializeComponent();
                pinInput.PasswordChar = '*';
            }
            else
            {
                var confirmUpdate = MessageBox.Show("The database is missing.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void verifyLogin()
        {
            if (accountInput.Text == "" || pinInput.Text == "")
            {
                MessageBox.Show("Please enter an account number and PIN.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (accountInput.Text.All(char.IsDigit) == false || accountInput.Text.Count() != 8)
            {
                MessageBox.Show("Account numbers can only contain numbers and must be 8 characters long.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pinInput.Text.All(char.IsDigit) == false || pinInput.Text.Count() != 4)
            {
                MessageBox.Show("PIN can only contain numbers and must be 4 characters long.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkLoginDetails() == false)
            {
                MessageBox.Show("Incorrect Account Number or PIN. Please try again.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                accountDetails accountDetails = new accountDetails(accountInput.Text);
                MessageBox.Show("Successfully logged in!",
                                     "Details Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accountInput.Text = "";
                pinInput.Text = "";
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
            verifyLogin();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"How_to_use.pdf");
        }
    }
}
