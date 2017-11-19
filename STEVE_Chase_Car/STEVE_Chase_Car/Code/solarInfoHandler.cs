using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEVE_Chase_Car.Code
{
    class SolarInfoHandler
    {
        Form1 screen;

        public SolarInfoHandler(Form1 _screen)
        {
            screen = _screen;
        }

        public void updateSolarInformation()
        {
            Code.solarInformationRootObject solarInformation = Code.apiInterface.getSolarInformation("57.782303", "14.162198", "today", "0");

            screen.updateSolarLables("Current Time: " + DateTime.Now.ToString("dd/mm/yyyy HH:mm"),
                                     "Sun Altitude: 90°",
                                     "Sun Direction: 66°",
                                     "Sun Distance: 144.5 million km",
                                     solarInformation.results.sunrise.Split('T')[1].Split('+')[0],
                                     solarInformation.results.sunset.Split('T')[1].Split('+')[0],
                                     solarInformation.results.solar_noon.Split('T')[1].Split('+')[0]);
        }
    }
}
