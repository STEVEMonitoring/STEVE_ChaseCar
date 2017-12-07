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
            timer_rec.Enabled = true;
            connected = true;
            
            mainScreenMenuStrip.ForeColor = Color.White;
            Form1.instance = this;
            openGraphForm();
            
        }


        void openGraphForm()
        {
            ChartView embeddedForm = new ChartView();
            embeddedForm.TopLevel = false;
            solarCellsPanel.Controls.Add(embeddedForm);
            embeddedForm.FormBorderStyle = FormBorderStyle.None;
            embeddedForm.Height = solarCellsPanel.Height;
            embeddedForm.Width = solarCellsPanel.Width;

            embeddedForm.Show();
        }

        public void updateSolarLables(string date, 
                                      string sunAltitude, 
                                      string sunDirection, 
                                      string sunDistance, 
                                      string sunRise, 
                                      string sunSet, 
                                      string solar_noon)
        {        
            lbCurrentTime.Text = date;
            lbSunAltitude.Text = sunAltitude;
            lbSunDirection.Text = sunDirection;
            lbSunDistance.Text = sunDistance;
            lbSunrise.Text = "Sunrise: " + sunRise;
            lbSunset.Text = "Sunset: " + sunSet;

            lbSunrisePicture.Text = sunRise;
            lbSunsetPicture.Text = sunSet;
            lbMeridianPicture.Text = solar_noon;
        }


        public void updateWeatherLables(string windSpeed, 
                                        string windDirection,
                                        string headWind,
                                        string crossWind,
                                        string windLevels,
                                        string airPressure,
                                        string uvIntensity,
                                        string cloudiness,
                                        string weather,
                                        string rain,
                                        string temperature,
                                        string humidity)
        {
            lbWindspeed.Text = windSpeed;
            lbWindDirection.Text = windDirection;
            lbHeadWind.Text = headWind;
            lbCrossWind.Text = crossWind;
            lbWindLevels.Text = windLevels;
            lbAirPressure.Text = airPressure;

            lbUvIntensity.Text = uvIntensity;
            lbCloudiness.Text = cloudiness;
            lbWeather.Text = weather;
            lbRainFall.Text = rain;
            lbCurrentTemp.Text = temperature;
            lbHumidity.Text = humidity;
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

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartView newChartView = new ChartView();
            newChartView.DbControls = mainScreenDbControl;
            newChartView.Show();
        }

        private void btnSunInfo_Click(object sender, EventArgs e)
        {
            SolarInfoHandler handler = new SolarInfoHandler(this);
            handler.updateSolarInformation();

        }

        private void btnWeatherTest_Click(object sender, EventArgs e)
        {
            WeatherInfoHandler handler = new WeatherInfoHandler(this);
            handler.updateWeather();
        }
    }
}
