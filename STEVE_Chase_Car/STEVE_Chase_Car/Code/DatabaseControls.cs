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
using System.IO;
using System.Windows.Media.Animation;
using STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters;
using Microsoft.SqlServer.Server;

namespace STEVE_Chase_Car.Code
{
    public class DatabaseControls
    {
        public string selectedServer { get; }
        public string selectedDatabase { get; }
        private bool connected = false;
        private int dbId = 0;

        public string DBconnectionSting { get; }

        public DatabaseControls(string _server, string _database)
        {
            selectedServer = _server;
            selectedDatabase = _database;
            DBconnectionSting = @"server=" + _server + ";" +
                                "Trusted_Connection=yes;" +
                                "database=" + _database + ";" +
                                "connection timeout=5;";
        }


        private void executeCommand(string script, SqlConnection conn)
        {
            SqlCommand myCommand = new SqlCommand(script, conn);

            myCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Creates a database with the chosen name
        /// </summary>
        /// <returns></returns>
        public bool createDatabase()
        {
            string str;
            try
            {
                createDatabaseAndTables(); /* Create database tables */
                MessageBox.Show("Database was Successfully Created!", "STEVE_ChaseCar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "STEVE_ChaseCar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
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
            string connectionSting = @"server=" + selectedServer + ";" +
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

        private void createDatabaseAndTables()
        {
            SqlConnection myConn = new SqlConnection(@"Server=" + selectedServer + ";Integrated security=SSPI;database=master");
            myConn.Open();

            try
            {
                string command = "CREATE DATABASE " + selectedDatabase;
                executeCommand(command, myConn);
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not create database \n" + e, "SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConn.Close();
            }

            try
            {  
                string script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreatePDO1.sql"));
                executeCommand(script, myConn);

                script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreatePDO2.sql"));
                executeCommand(script, myConn);

                script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreateMotorFrame0.sql"));
                executeCommand(script, myConn);

                script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreateMotorFrame1.sql"));
                executeCommand(script, myConn);

                script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreateMotorFrame2.sql"));
                executeCommand(script, myConn);

                script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + @"\\SQL Commands\CreateMPPT.sql"));
                executeCommand(script, myConn);

                myConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not create database tables as they may already exist" + e, "SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myConn.Close();
            }
            
        }

        public bool DBaddData(STEVE_DatabaseDataSet steveDatabase)
        {
            STEVE_DatabaseDataSet.BMS_PDO1Row newPDO1Row = steveDatabase.BMS_PDO1.NewBMS_PDO1Row();
            STEVE_DatabaseDataSet.BMS_PDO1DataTable dataTable = new STEVE_DatabaseDataSet.BMS_PDO1DataTable();
            BMS_PDO1TableAdapter tableAdapter = new BMS_PDO1TableAdapter();

            dbId += 1;
            newPDO1Row.ID = dbId;
            newPDO1Row.Time = DateTime.Now;
            newPDO1Row.minVolt = 15;
            newPDO1Row.minVoltID = 11;
            newPDO1Row.maxVolt = 200;
            newPDO1Row.maxVoltID = 10;
            newPDO1Row.volt = 58;
            newPDO1Row.current = 5;


            steveDatabase.BMS_PDO1.Rows.Add(newPDO1Row);
            tableAdapter.Adapter.Update(steveDatabase.BMS_PDO1);    

            return true;
        }

    }
}
