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

namespace STEVE_Chase_Car
{
    public partial class Form1 : Form
    {

        private CANinterfaceControls canControls = new CANinterfaceControls();

        public DatabaseControls mainScreenDbControl { get; set; }
        private bool connected = false;
        private string server;
        private string database;
        private int dbId = 0;

        public Form1()
        {
            InitializeComponent();
            initWebbrowser();
            timer_rec.Enabled = true;
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
            try
            {
                if (TBdatabase.Text == "" || TBserver.Text == "")
                {
                    throw new System.ArgumentException("Invalid values in server or database selection");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            statusRTXB.AppendText("Creating Connection.. \n");
            string connectionSting = "server=" + TBserver.Text + ";" +
                                     "Trusted_Connection=yes;" +
                                      "database=" + TBdatabase.Text + ";" +
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

        private void bMS_PDO1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bMS_PDO1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTEVE_databaseDataSet);

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

            STEVE_databaseDataSet.BMS_PDO1Row newPDO1Row = sTEVE_databaseDataSet.BMS_PDO1.NewBMS_PDO1Row();

            dbId += 1;
            newPDO1Row.Id = dbId;
            newPDO1Row.Time = DateTime.Now;
            newPDO1Row.MinVolt = "20";
            newPDO1Row.MinVoltID = "AZ";
            newPDO1Row.MaxVolt = "100";
            newPDO1Row.MaxVoltID = "AJ";
            newPDO1Row.Volt = 58;
            newPDO1Row.Current = 5;

            try
            {
                sTEVE_databaseDataSet.BMS_PDO1.Rows.Add(newPDO1Row);
                this.bMS_PDO1TableAdapter.Update(this.sTEVE_databaseDataSet.BMS_PDO1);
                //this.Validate();
                //this.bMS_PDO1BindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.sTEVE_databaseDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load selected data, data is wrong or already existing", "SQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void testBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void loadDataBTN_Click_1(object sender, EventArgs e)
        {

        }
    }
}
