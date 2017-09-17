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
using STEVE_Chase_Car.Code;
using Microsoft.SqlServer.Server;
using STEVE_Chase_Car.FormsWindows;

namespace STEVE_Chase_Car
{
    public partial class Form1 : Form
    {
        static public Form1 instance;
        private CANinterfaceControls canControls = new CANinterfaceControls();

        public DatabaseControls mainScreenDbControl { get; set; }
        private bool connected = false;
        private bool tablesCreated = false;
        private string server;
        private string database;
        private int dbId = 0;

        public Form1()
        {
            InitializeComponent();
            initWebbrowser();
            timer_rec.Enabled = true;
            connected = true;

            Form1.instance = this;
        }

        private void initWebbrowser()
        {
            weatherBrowser.ScriptErrorsSuppressed = true;
            solarBrowser.ScriptErrorsSuppressed = true;
            weatherBrowser.Navigate("https://www.yr.no/place/Sweden/");
            solarBrowser.Navigate("https://www.wolframalpha.com/input/?i=sun");
        }


        private void testBTN_Click(object sender, EventArgs e)
        {

            statusRTXB.AppendText("Creating Connection.. \n");
            string connectionSting = "server=" + mainScreenDbControl.selectedServer + ";" +
                                     "Trusted_Connection=yes;" +
                                      "database=" + mainScreenDbControl.selectedDatabase + ";" +
                                      "connection timeout=5;";
            


            SqlConnection sqlConn = new SqlConnection(connectionSting);

            try
            {
                statusRTXB.AppendText("Trying Connection.. \n");
                sqlConn.Open();
                sqlConn.Close();
                statusRTXB.AppendText("Connection ok! \n");

                connected = true;
                server = TBserver.Text;
                database = TBdatabase.Text;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Connection could not be etablished with the SQL database", "SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusRTXB.AppendText("Connection Failed");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTEVE_databaseDataSet.BMS_PDO1' table. You can move, or remove it, as needed.
            //this.bMS_PDO1TableAdapter.Fill(this.sTEVE_databaseDataSet.BMS_PDO1);

        }

        private void loadDataBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    throw new System.OperationCanceledException("No verified database connection.");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //mainScreenDbControl.DBaddData();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReloadBrowsers_Click(object sender, EventArgs e)
        {
            initWebbrowser();
        }


        private void timer_rec_Tick(object sender, EventArgs e)
        {
            //canControls.TimerTickEvent();

        }

        private void dev_CANalyst_btnConnect_Click(object sender, EventArgs e)
        {
            canControls.CanConnect(0, "00000000", "FFFFFFFF", "03", "1C", 0, 0);
            canControls.StartCan();
        }

        private void dev_CANalyst_btnDisconnect_Click(object sender, EventArgs e)
        {
            canControls.StopCan();
        }

        private void dev_CANalyst_btnSend_Click(object sender, EventArgs e)
        {
            canControls.CanTransmit(0, 0, 0x0, 0, "00 01 02 03 04 05 06 07 ");
        }

        public void dev_CANalyst_Console_Put(string text)
        {
            dev_CANalyst_Console.Text += text + '\n';
        }

        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            //mainScreenDbControl.createTables();
        }

        private void rawViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseRawView newView = new DatabaseRawView();
            newView.DbControls = mainScreenDbControl;
            newView.Show();
        }
    }
}
