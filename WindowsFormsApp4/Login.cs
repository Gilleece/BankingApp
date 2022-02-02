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
    public partial class Login : Form
    {

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
    }
}
