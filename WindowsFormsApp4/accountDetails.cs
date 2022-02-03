using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace BankingApp
{
    public partial class accountDetails : Form
    {

        public dbConnector accountsDbConnection = new dbConnector(@"accounts.db");

        public accountDetails(string loggedInAccount)
        {
            InitializeComponent();
            DataTable accountDetailsDT = accountsDbConnection.getAccountDetails(loggedInAccount);
            nameBox.Text = accountDetailsDT.Rows[0][2].ToString();
            accNumBox.Text = accountDetailsDT.Rows[0][0].ToString();
            ibanBox.Text = accountDetailsDT.Rows[0][1].ToString();
            eircodeBox.Text = accountDetailsDT.Rows[0][4].ToString();
            balanceBox.Text = accountDetailsDT.Rows[0][3].ToString();
        }

        private void acccountDetails_Load(object sender, EventArgs e)
        {           
        }
    }
}
