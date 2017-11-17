using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEVE_Chase_Car.Code
{
    class SolarInfoHandler
    {
        private Code.solarInformationRootObject solarInformation;
        Form1 screen;

        public SolarInfoHandler(Form1 _screen)
        {
            screen = _screen;
        }

        void updateSolarInformation()
        {
            solarInformation = Code.apiInterface.getSolarInformation("57.782303", "14.162198", "today", "0");
        }

        public void updateLabels()
        {
            this.updateSolarInformation();
            screen.updateSolarLables(DateTime.Now, "90", "East", "144.5 million Km", solarInformation.results.sunrise, solarInformation.results.sunset);
        }
    }
}
