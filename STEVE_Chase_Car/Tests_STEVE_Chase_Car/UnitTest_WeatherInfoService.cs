using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using STEVE_Chase_Car.Code;

namespace Tests_STEVE_Chase_Car
{
    [TestClass]
    public class UnitTest_WeatherInfoService
    {
        [TestMethod]
        public void ReturnsJsonResponse()
        {
            WeatherInfoService weatherInfoService = new WeatherInfoService();
            WeatherInformation actual = weatherInfoService.GetWeatherInfo(5f, 7f);

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void ReturnsNullWhenLatitudeIsInvalid()
        {
            WeatherInfoService weatherInfoService = new WeatherInfoService();
            WeatherInformation actual = weatherInfoService.GetWeatherInfo(91f, 7f);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ReturnsNullWhenLongitudeIsInvalid()
        {
            WeatherInfoService weatherInfoService = new WeatherInfoService();
            WeatherInformation actual = weatherInfoService.GetWeatherInfo(7f, -181f);

            Assert.IsNull(actual);
        }
    }
}
