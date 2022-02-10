using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace BankingApp
{
    public partial class editDetails : Form
    {
        string currentAcc;

        public dbConnector myBankDbconnector = new dbConnector(@"accounts.db");

        public editDetails(string accNum)
        {
            InitializeComponent();
            currentAcc = accNum;
            DataTable accountDetailsDT = myBankDbconnector.getAccountDetails(accNum);
            nameBox.Text = accountDetailsDT.Rows[0][2].ToString();
            eircodeBox.Text = accountDetailsDT.Rows[0][4].ToString();
            pinBox.Text = accountDetailsDT.Rows[0][5].ToString();
        }

        private void ibanBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            accountDetails accountDetails = new accountDetails(currentAcc);
            accountDetails.Show();
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || eircodeBox.Text == "" || pinBox.Text == "")
            {
                MessageBox.Show("No input fields can be empty.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pinBox.Text.All(char.IsDigit) == false || pinBox.Text.Count() != 4)
            {
                MessageBox.Show("PIN can only contain numbers and must be 4 characters long.");
            }
            else if (eircodeBox.Text.Count() != 7)
            {
                MessageBox.Show("Please enter a valid, 7 character long, Eircode.");
            }
            else
            {
                myBankDbconnector.updateDetails(currentAcc, nameBox.Text, eircodeBox.Text, pinBox.Text);
                MessageBox.Show("Details updated.",
                                         "Update confirmed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accountDetails accountDetails = new accountDetails(currentAcc);
                accountDetails.Show();
                Close();
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"How_to_use.pdf");
        }
    }
}
