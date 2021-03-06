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

        public bool checkCredentials(string accNum, string pin)
        {
            try
            {
                DataTable dtCount = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT COUNT() FROM accounts WHERE accountNo = @accNum AND pin = @pin;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@accNum", accNum);
                sqlcomCommand.Parameters.AddWithValue("@pin", pin);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtCount);
                    if (dtCount.Rows[0][0].ToString() == "1")
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
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

        public DataTable getAccountDetails(string accNum)
        {
            try
            {
                DataTable dtAccountDetails = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM accounts WHERE accountNo = @accNum;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@accNum", accNum);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtAccountDetails);
                    return dtAccountDetails;
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

        public void updateDetails(string accNum, string name, string eircode, string pin)
        {
            try
            {
                sqlconnConnection.Open();
                string strInsert = @"UPDATE accounts SET fullName = @name, eircode = @eircode, pin = @pin WHERE accountNo = @accNum;";
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strInsert, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@accNum", accNum);
                sqlcomCommand.Parameters.AddWithValue("@name", name);
                sqlcomCommand.Parameters.AddWithValue("@eircode", eircode);
                sqlcomCommand.Parameters.AddWithValue("@pin", pin);

                try
                {
                    sqlcomCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"UPDATE unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }
    }
}

