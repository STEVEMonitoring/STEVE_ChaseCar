using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace STEVE_Chase_Car.Code
{
    class apiInterface
    {

        public static Code.weatherInformationRootObject getWeatherInformation(string lat, string lon)
        {
            /*  https://home.openweathermap.org/
             *  Username: zifuc@nezdiro.org
             *  Password: jthSolarAcc
             */
            return Code.apiInterface._download_serialized_json_data<Code.weatherInformationRootObject>("https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&APPID=e72c23f10850d6da8d484b6da912172d");
        }

        public static Code.solarInformationRootObject getSolarInformation(string lat, string lng, string date, string format)
        {
            return Code.apiInterface._download_serialized_json_data<Code.solarInformationRootObject>("https://api.sunrise-sunset.org/json?lat=" + lat + "&lng=" + lng + "&date=" + date + "&formatted=" + format);
        }
        
        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {

                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

    }
}
