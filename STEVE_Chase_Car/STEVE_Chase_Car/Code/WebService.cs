using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace STEVE_Chase_Car.Code
{
    public class WebService
    {
        private String response;
        public String GetResponse(String url)
        {
            using (var webClient = new WebClient())
            {
                this.response = null;
                try
                {
                    this.response = webClient.DownloadString(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine("WebService GetResponse: " + e.Message);
                }

                return this.response;
            }
        }

        public bool IsValidJson(String text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }

            try
            {
                var serializer = new JavaScriptSerializer();
                dynamic obj = serializer.Deserialize(text, typeof(object));

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("WebService IsValidJson: " + e.Message);
            }
            return false;
        }

        public T GetJson<T>(String url)
        {
            if (IsValidJson(GetResponse(url)))
            {
                var serializer = new JavaScriptSerializer();
                return serializer.Deserialize<T>(this.response);
            }

            return default(T);
        }
        
    }

    public class SolarInfoService
    {
        private readonly string URL = "https://api.sunrise-sunset.org/json?lat=LATITUDE&lng=LONGITUDE";
        private WebService webService = new WebService();
        
        public SolarInformation GetSolarInfo(float latitude, float longitude, DateTime? date = null)
        {
            if (!CoordinatesAreValid(latitude, longitude))
            {
                return null;
            }

            String url = URL.Replace("LATITUDE", string.Format("{0:N5}", latitude)).Replace("LONGITUDE", string.Format("{0:N5}", longitude)) + "&date=today&formatted=0"; // URL.Replace("LATITUDE", latitude.ToString()).Replace("LONGITUDE", longitude.ToString());
            SolarInformation retVal = webService.GetJson<SolarInformation>(url);
            try
            {
                if (retVal.status == "OK")
                {
                    return retVal;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("SolarInformation GetSolarInfo: " + e.Message);
            }
            return null;
        }

        bool CoordinatesAreValid(float latitude, float longitude)
        {
            return (-90f <= latitude && latitude <= 90f) && (-180f < longitude && longitude < 180f);
        }

    }

    public class WeatherInfoService
    {
        private readonly string URL = "https://api.openweathermap.org/data/2.5/weather?APPID=e72c23f10850d6da8d484b6da912172d&units=metric&lat=LATITUDE&lon=LONGITUDE";
        private WebService webService = new WebService();

        public WeatherInformation GetWeatherInfo(float latitude, float longitude)
        {
            if (!CoordinatesAreValid(latitude, longitude))
            {
                return null;
            }

            String url = URL.Replace("LATITUDE", string.Format("{0:N5}", latitude)).Replace("LONGITUDE", string.Format("{0:N5}", longitude)); // URL.Replace("LATITUDE", latitude.ToString()).Replace("LONGITUDE", longitude.ToString());
            WeatherInformation retVal = webService.GetJson<WeatherInformation>(url);
            try
            {
                if (retVal.cod == 200)
                {
                    return retVal;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("WeatherInfoService GetWeatherInfo: " + e.Message);
            }
            return null;
        }

        bool CoordinatesAreValid(float latitude, float longitude)
        {
            return (-90f <= latitude && latitude <= 90f) && (-180f < longitude && longitude < 180f);
        }
    }
}
