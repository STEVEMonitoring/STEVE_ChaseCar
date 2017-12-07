using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using STEVE_Chase_Car.Code;

namespace Tests_STEVE_Chase_Car
{
    [TestClass]
    public class UnitTest_SolarInfoService
    {
        [TestMethod]
        public void ReturnsJsonResponse()
        {
            SolarInfoService solarInfoService = new SolarInfoService();
            SolarInformation actual = solarInfoService.GetSolarInfo(5f, 7f);

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void ReturnsNullWhenLatitudeIsInvalid()
        {
            SolarInfoService solarInfoService = new SolarInfoService();
            SolarInformation actual = solarInfoService.GetSolarInfo(91f, 7f);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ReturnsNullWhenLongitudeIsInvalid()
        {
            SolarInfoService solarInfoService = new SolarInfoService();
            SolarInformation actual = solarInfoService.GetSolarInfo(7f, -181f);

            Assert.IsNull(actual);
        }
    }
}
