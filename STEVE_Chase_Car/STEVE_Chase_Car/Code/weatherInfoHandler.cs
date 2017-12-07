using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEVE_Chase_Car.Code
{
    class WeatherInfoHandler
    {
        /*Form1 screen;

        public WeatherInfoHandler(Form1 _screen)
        {
            screen = _screen;
        }

        public void updateWeather()
        {
            Code.WeatherInformation weatherInformation = Code.apiInterface.getWeatherInformation("57.782303", "14.162198");
            string rain;

            if(weatherInformation.rain != null)
            {
                rain = weatherInformation.rain.ToString();
            }
            else
            {
                rain = "0";
            }

            screen.updateWeatherLables("Current Windspeed: " + weatherInformation.wind.speed.ToString() + " m/s",
                                       "Current Wind Direction: " + weatherInformation.wind.deg.ToString() + "°",
                                       "Solar car head wind: n/a",
                                       "Solar car cross wind: n/a",
                                       "Estimated levels today: n/a",
                                       "Air Pressure: " + weatherInformation.main.pressure.ToString() + " hPa",
                                       "UV Intensity: n/a",
                                       "Cloudiness: " + weatherInformation.clouds.all.ToString() + "%",
                                       "Weather: " + weatherInformation.weather[0].description.ToString(),
                                       "Rainfall: " + rain + " volume/3h",
                                       "Temperature: " + (weatherInformation.main.temp - 273.15) + "C",
                                       "Humidity: " + weatherInformation.main.humidity.ToString() + "%");
        }*/

    }
}
