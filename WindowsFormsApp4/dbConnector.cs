using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Xml;

namespace BankingApp
{
    public class dbConnector
    {

        private static SQLiteConnection sqlconnConnection;
        public DataSet myAppDataSet = new DataSet();   // created for you to use and push data into


        public dbConnector(string strFilePath)
        {
            // this is a constructor that will automatically be run when the class is created.
            // it does require a filename/location of the DB file you will be using.
            //strFilePath = location on your database.
            try
            {
                sqlconnConnection = new SQLiteConnection("Data Source=" + strFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception("DbConnector initialisation unsuccessful:\n" + ex.Message);
            }
        }

        public DataTable FetchMessageDataFromTable() // Original param: string strSenderGuid
        {
            // sample of a well formed Method to connect to the DB and perform certain functions
            try
            {
                DataTable dtAccounts = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM accounts;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtAccounts);
                    return dtAccounts;
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }
    }
}

