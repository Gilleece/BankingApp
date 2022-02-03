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
    public partial class accountDetails : Form, IMessageFilter
    {

        public dbConnector accountsDbConnection = new dbConnector(@"accounts.db");
        private System.Windows.Forms.Timer inactivityTimer;

        public accountDetails(string loggedInAccount)
        {
            InitializeComponent();
            DataTable accountDetailsDT = accountsDbConnection.getAccountDetails(loggedInAccount);
            nameBox.Text = accountDetailsDT.Rows[0][2].ToString();
            accNumBox.Text = accountDetailsDT.Rows[0][0].ToString();
            ibanBox.Text = accountDetailsDT.Rows[0][1].ToString();
            eircodeBox.Text = accountDetailsDT.Rows[0][4].ToString();
            balanceBox.Text = accountDetailsDT.Rows[0][3].ToString();
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = 60000; // 60 second timer
            inactivityTimer.Tick += LogoutUser;
            inactivityTimer.Enabled = true;
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message message)
        {
            bool active = message.Msg == 0x100 || message.Msg == 0x101;
            active = active || message.Msg == 0xA0 || message.Msg == 0x200;
            active = active || message.Msg == 0x10;
            if (active)
            {
                inactivityTimer.Enabled = false;
                inactivityTimer.Start();
            }
            return false;
        }

        private void LogoutUser(object sender, EventArgs e)
        {
            inactivityTimer.Enabled = false;
            var confirmUpdate = MessageBox.Show("You have been logged out due to inactivity.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private void acccountDetails_Load(object sender, EventArgs e)
        {           
        }
    }
}
