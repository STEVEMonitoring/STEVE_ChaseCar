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
using System.Globalization;
using System.IO;
using System.Reflection;

namespace STEVE_Chase_Car
{
    public partial class Form1 : Form
    {
        static public Form1 instance;
        ChartView embeddedFormChart = new ChartView();

        public DatabaseControls mainScreenDbControl { get; set; }
        private bool connected = false;
        private bool tablesCreated = false;
        private string server;
        private string database;
        private int dbId = 0;


        enum WeatherId
        {
            thunderS = 200,
            thunderE = 232,
            rainS = 300,
            rainE = 531,
            snowS = 600,
            snowE = 622,
            clear = 800,
            cloudsS = 801,
            cloudsE = 804
        }


        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            connected = true;

            mainScreenMenuStrip.ForeColor = Color.White;
            Form1.instance = this;

            /* Opens a graph window */
            openGraphForm();

            /* Init all lables and timers */
            //canControls.TimerTickEvent();
            updateWeatherLables((float)numLat.Value, (float)numlong.Value);
            updateSolarLables((float)numLat.Value, (float)numlong.Value);

            timerUpdateLables.Enabled = true;
            timerUpdateWeatherSun.Enabled = true;
            timer_rec_can.Enabled = true;

            /* do not allow tire diameter to be > 100 or < 1 */
            numTireDiameter.Minimum = 1;
            numTireDiameter.Maximum = 100;
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
            SolarInformation solar = new SolarInfoService().GetSolarInfo(latitude, longitude);
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
            WeatherInformation weatherData = new WeatherInfoService().GetWeatherInfo(latitude, longitude);
            String notAvailable = "N/A";
            lbWindspeed.Text = "Current wind speed: " + weatherData.wind.speed.ToString() + " m/s";
            lbWindDirection.Text = "Current wind direction: " + weatherData.wind.deg.ToString() + "°";
            lbHeadWind.Text = "Solar car headwind: " + notAvailable;
            lbCrossWind.Text = "Solar car crosswind: " + notAvailable;
            lbAirPressure.Text = "Air pressure: " + weatherData.main.pressure.ToString() + " hPa";

            lbUvIntensity.Text = "UV-intensity: " + notAvailable;
            lbCloudiness.Text = "Cloudiness: " + weatherData.clouds.all.ToString();
            lbWeather.Text = "Weather: " + weatherData.weather[0].description;
            lbRainFall.Text = "Rainfall: " + (weatherData.rain != null ? weatherData.rain.__invalid_name__3h.ToString() + " mm" : "0 mm");
            lbCurrentTemp.Text = "Temperature: " + weatherData.main.temp.ToString() + "°C";
            lbHumidity.Text = "Humidity: " + weatherData.main.humidity.ToString() + "%";

            lbLocation.Text = "Location: " + weatherData.name.ToString();

            updateWeatherImage(weatherData.weather[0].id);
        }

        private void updateBatteryLables()
        {
            lbCharge.Text = "State of charge: " + float.Parse(mainScreenDbControl.getDbData("SELECT SOC FROM BMS_PDO2 WHERE ID =(SELECT MAX(id) FROM BMS_PDO2)")) + "%";
            lbBatteryVoltage.Text = "Battery Voltage: " + mainScreenDbControl.getDbData("SELECT volt FROM BMS_PDO1 WHERE ID =(SELECT MAX(id) FROM BMS_PDO1)") + "mV";
            //lbBatteryCurrent.Text = "Battery Current: " + mainScreenDbControl.getDbData("SELECT current FROM BMS_PDO1 WHERE ID =(SELECT MAX(id) from BMS_PDO1)") + "mA";

            lbTemp.Text = "Temperature: " + float.Parse(mainScreenDbControl.getDbData("SELECT maxTemp FROM BMS_PDO2 WHERE ID =(SELECT MAX(id) from BMS_PDO2)"))/10 + "°C";
            lbCurrentPeak.Text = "Current Peak Average: N/A A";
            lbCellBalance.Text = "Cell Balance: N/A mV";

            return;

            double maxBatteryVoltage = 300;
            double batteryVoltage = Int32.Parse(mainScreenDbControl.getDbData("SELECT batteryVoltage FROM MotorFrame0 WHERE ID =(SELECT MAX(id) FROM MotorFrame0)"));
            lbCharge.Text = "State of charge: " + Math.Round(((batteryVoltage / maxBatteryVoltage)*100), 1).ToString() + "%";
            lbBatteryVoltage.Text = "Battery Voltage: " + batteryVoltage.ToString() + "V";
            lbBatteryCurrent.Text = "Battery Current: " + mainScreenDbControl.getDbData("SELECT batteryCurrent FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "A";

            lbTemp.Text = "Temperature: " + mainScreenDbControl.getDbData("SELECT fetTemp FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "°C";
            lbCurrentPeak.Text = "Current Peak Avrage: " + mainScreenDbControl.getDbData("SELECT motorCurrentPeakAvrage FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)") + "A";
            lbCellBalance.Text = "Cell Balance: " + "100" + "mV";
        }

        private void updateSpeedLables()
        {
            int RPM = Int32.Parse(mainScreenDbControl.getDbData("SELECT motorRotationSpeed FROM MotorFrame0 WHERE ID =(SELECT MAX(id) from MotorFrame0)"));
            lbSpeed.Text = "Current Speed: " + Math.Round(((RPM * (3.14 * (int)numTireDiameter.Value)*60)/100000), 0) + " km/h";
            lbRecSpeed.Text = "Recommended Speed: 100 km/h";
            lbRoadInclination.Text = "Road Inclination: 5°";
            lbGainedEnergy.Text = "Gained Energy: -";
            lbSolarEnergy.Text = "Solar Energy: -";
            lbMotorConsumption.Text = "Motor Consumption: 25W";
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_rec_Tick(object sender, EventArgs e)
        {
            //canControls.TimerTickEvent();
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            embeddedFormChart.Height = graphPanel.Height;
            embeddedFormChart.Width = graphPanel.Width;
        }

        private void timerUpdateLables_Tick(object sender, EventArgs e)
        {
            updateBatteryLables();
            updateSpeedLables();
        }

        private void updateWeatherSun_Tick(object sender, EventArgs e)
        {
            updateWeatherLables((float)numLat.Value, (float)numlong.Value);
            updateSolarLables((float)numLat.Value, (float)numlong.Value);
        }

        private void updateWeatherImage(int id)
        {
            if(id == (int)WeatherId.clear) //Clear skies
            {
                picBoxWeather.Image = Properties.Resources.clearSkies;
            }
            else if (id >= (int)WeatherId.cloudsS && id <= (int)WeatherId.cloudsE) //Clouds
            {
                picBoxWeather.Image = Properties.Resources.cloud;
            }
            else if (id >= (int)WeatherId.rainS && id <= (int)WeatherId.rainE) //Rain
            {
                picBoxWeather.Image = Properties.Resources.Cloud_rain;
            }
            else if (id >= (int)WeatherId.snowS && id <= (int)WeatherId.snowE) //Snow
            {
                picBoxWeather.Image = Properties.Resources.snow;
            }
            else if (id >= (int)WeatherId.thunderS && id <= (int)WeatherId.thunderE) // Thunder
            {
                picBoxWeather.Image = Properties.Resources.cloud_thunder;
            }
            else
            {
                picBoxWeather.Image = Properties.Resources.cloud;
            }

           
            //picBoxWeather.Load();
        }

        private void btnUpdateLocation_Click(object sender, EventArgs e)
        {
            updateWeatherLables((float)numLat.Value, (float)numlong.Value);
            updateSolarLables((float)numLat.Value, (float)numlong.Value);
        }

        private void rawViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatabaseRawView newView = new DatabaseRawView();
            newView.DbControls = mainScreenDbControl;
            newView.Show();
        }

        private void chartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChartView newChartView = new ChartView();
            newChartView.DbControls = mainScreenDbControl;
            newChartView.Show();
        }

        private void communicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            canCommunication canCommunication = new canCommunication();
            canCommunication.Show();
        }
    }
}
