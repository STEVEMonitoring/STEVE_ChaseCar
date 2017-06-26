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

namespace STEVE_Chase_Car.Code
{
    class DatabaseControls
    {
        private bool connected = false;
        private string selectedServer;
        private string selectedDatabase;
        private int dbId = 0;

        /// <summary>
        /// Tests the chosen database, if a connection can
        /// be established returns true
        /// </summary>
        /// <param name="database"></param>
        /// <param name="server"></param>
        /// <returns></returns>
        bool connectionOk(string database, string server)
        {
            try
            {
                if (database == "" || server == "")
                {
                    throw new System.ArgumentException("Invalid values in server or database selection");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string connectionSting = "server=" + server + ";" +
                                     "Trusted_Connection=yes;" +
                                      "database=" + database + ";" +
                                      "connection timeout=5;";

            SqlConnection sqlConn = new SqlConnection(connectionSting);

            try
            {
                sqlConn.Open();
                sqlConn.Close();
                connected = true;
                selectedServer = server;
                selectedDatabase = database;
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
