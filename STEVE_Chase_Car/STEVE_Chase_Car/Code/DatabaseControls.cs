using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Media.Animation;

namespace STEVE_Chase_Car.Code
{
    class DatabaseControls
    {
        private string selectedServer;
        private string selectedDatabase;
        private string password;
        private string userName;
        private bool connected = false;
        private int dbId = 0;

        public DatabaseControls(string _server, string _database, string _userName, string _password)
        {
            selectedServer = _server;
            selectedDatabase = _database;
            userName = _userName;
            password = _password;
        }

        /// <summary>
        /// Creates a database with the chosen name
        /// </summary>
        /// <returns></returns>
        public bool createDatabase()
        {
            string str;
            if (selectedDatabase == "")
            {
                MessageBox.Show("Please enter a correct database name in order to create it", "SQL Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            SqlConnection myConn = new SqlConnection(@"Server=" + selectedServer + ";Integrated security=SSPI;database=master");

            str = "CREATE DATABASE " + selectedDatabase;

            SqlCommand myCommand = new SqlCommand(str, myConn);       
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Database was Successfully Created!", "STEVE_ChaseCar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "STEVE_ChaseCar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        /// <summary>
        /// Tests the chosen database, if a connection can
        /// be established returns true
        /// </summary>
        /// <param name="database"></param>
        /// <param name="server"></param>
        /// <returns></returns>
        public bool ConnectionOk()
        {
            try
            {
                if (selectedDatabase == "" || selectedServer == "")
                {
                    throw new System.ArgumentException("Invalid values in server or database selection");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (true)
            {

            }
            string connectionSting = "server=" + selectedServer + ";" +
                                     "Trusted_Connection=yes;" +
                                      "database=" + selectedDatabase + ";" +
                                      "connection timeout=5;";

            SqlConnection sqlConn = new SqlConnection(connectionSting);

            try
            {
                sqlConn.Open();
                sqlConn.Close();
                connected = true;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection could not be etablished with the SQL database", "SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
