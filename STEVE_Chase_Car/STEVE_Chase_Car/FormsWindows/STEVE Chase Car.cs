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
        ChartView embeddedFormChart = new ChartView();

        public DatabaseControls mainScreenDbControl { get; set; }
        private bool connected = false;
        private bool tablesCreated = false;
        private string server;
        private string database;
        private int dbId = 0;


        public Form1()
        {
            InitializeComponent();
            connected = true;
            
            mainScreenMenuStrip.ForeColor = Color.White;
            Form1.instance = this;

            /* Opens a graph window */
            openGraphForm();

            /* Init all lables and timers */
            //canControls.TimerTickEvent();
            updateWeatherLables(12.4258916f, 130.8632683f);
            updateSolarLables(12.4258916f, 130.8632683f);

            timerUpdateLables.Enabled = true;
            timerUpdateWeatherSun.Enabled = true;
            timer_rec_can.Enabled = true;
        }


        void openGraphForm()
         {
            embeddedFormChart.TopLevel = false;
            graphPanel.Controls.Add(embeddedFormChart);
            embeddedFormChart.FormBorderStyle = FormBorderStyle.None;
            embeddedFormChart.Height = graphPanel.Height;
            embeddedFormChart.Width = graphPanel.Width;

            embeddedFormChart.Show();
         }


    private void updateSolarLables(float latitude, float longitude, DateTime? date = null)
        {
            SolarInformation solar = new SolarInfoService().GetSolarInfo(-12.4258916f, 130.8632683f);
            String notAvailable = "N/A";

            String sunrise = solar.results.sunrise.Split('T')[1].Split('+')[0];
            String sunset = solar.results.sunset.Split('T')[1].Split('+')[0];
            String noon = solar.results.solar_noon.Split('T')[1].Split('+')[0];

            lbCurrentTime.Text = "Current time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Maybe use suncalc.org for these
            lbSunAltitude.Text = "Sun altitude: " + notAvailable;
            lbSunDirection.Text = "Sun direction: " + notAvailable;
            lbSunDistance.Text = "Sun distance: " + notAvailable;

            lbSunrise.Text = "Sunrise: " + sunrise;
            lbSunset.Text = "Sunset: " + sunset;

            lbSunrisePicture.Text = sunrise;
            lbSunsetPicture.Text = sunset;
            lbMeridianPicture.Text = noon;
        }


        private void updateWeatherLables(float latitude, float longitude)
        {
            WeatherInformation weather = new WeatherInfoService().GetWeatherInfo(-12.4258916f, 130.8632683f);
            String notAvailable = "N/A";
            lbWindspeed.Text = "Current wind speed: " + weather.wind.speed.ToString() + " m/s";
            lbWindDirection.Text = "Current wind direction: " + weather.wind.deg.ToString() + "°";
            lbHeadWind.Text = "Solar car headwind: " + notAvailable;
            lbCrossWind.Text = "Solar car crosswind: " + notAvailable;
            lbWindLevels.Text = "Estimated wind levels today: " + notAvailable;
            lbAirPressure.Text = "Air pressure: " + weather.main.pressure.ToString() + " hPa";

            lbUvIntensity.Text = "UV-intensity: " + notAvailable;
            lbCloudiness.Text = "Cloudiness: " + weather.clouds.all.ToString();
            lbWeather.Text = "Weather: " + weather.weather[0].description;
            lbRainFall.Text = "Rainfall: " + (weather.rain != null ? weather.rain.__invalid_name__3h.ToString() + " mm" : "0 mm");
            lbCurrentTemp.Text = "Temperature: " + weather.main.temp.ToString() + "°C";
            lbHumidity.Text = "Humidity: " + weather.main.humidity.ToString() + "%";
        }

        private void updateBatteryLables()
        {
            double maxBatteryVoltage = 300;
            double batteryVoltage = Int32.Parse(mainScreenDbControl.getDbData("SELECT batteryVoltage FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)"));
            lbCharge.Text = "State of charge: " + Math.Round(((batteryVoltage / maxBatteryVoltage)*100), 1).ToString() + "%";
            lbBatteryVoltage.Text = "Battery Voltage: " + batteryVoltage.ToString() + "V";
            lbBatteryCurrent.Text = "Battery Current: " + mainScreenDbControl.getDbData("SELECT batteryCurrent FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "A";

            lbTemp.Text = "Temperature: " + mainScreenDbControl.getDbData("SELECT fetTemp FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "°C";
            lbCurrentPeak.Text = "Current Peak Avrage: " + mainScreenDbControl.getDbData("SELECT motorCurrentPeakAvrage FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "A";
            lbCellBalance.Text = "Cell Balance: " + "100" + "mV";

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
            float darwin_latitude = -12.4258916f;
            float darwin_longitude = 130.8632683f;
            updateSolarLables(darwin_latitude, darwin_longitude);

        }

        private void btnWeatherTest_Click(object sender, EventArgs e)
        {
            float darwin_latitude = -12.4258916f;
            float darwin_longitude = 130.8632683f;
            updateWeatherLables(darwin_latitude, darwin_longitude);
            updateBatteryLables(); //TEST
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            embeddedFormChart.Height = graphPanel.Height;
            embeddedFormChart.Width = graphPanel.Width;
        }

        private void timerUpdateLables_Tick(object sender, EventArgs e)
        {
            updateBatteryLables();
        }

        private void updateWeatherSun_Tick(object sender, EventArgs e)
        {
            updateWeatherLables(12.4258916f, 130.8632683f);
            updateSolarLables(12.4258916f, 130.8632683f);
        }
    }
}
