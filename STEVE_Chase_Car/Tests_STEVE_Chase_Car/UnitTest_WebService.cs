using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using STEVE_Chase_Car.Code;

namespace Tests_STEVE_Chase_Car
{
    [TestClass]
    public class UnitTest_WebService
    {
        /*
        [TestMethod]
        public void CanGetHttpResponseFromService()
        {
            String url = "http://www.google.com"; // https://api.openweathermap.org/data/2.5/weather?lat=1&lon=1&APPID=e72c23f10850d6da8d484b6da912172d
            WebService webService = new WebService(url);
            Assert.IsTrue(webService.ServiceIsAvailable());
        }*/

        [TestMethod]
        public void CanGetResponse()
        {
            String url = "http://echo.jsontest.com/one/two"; // http://echo.jsontest.com/key/value/one/two
            String expectedResponse =
                "{\"one\": \"two\"}\n";

            WebService webService = new WebService();
            String actual = webService.GetResponse(url);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void ValidatesValidJson()
        {
            String input = "{ \"age\" :20, \"Car\": \"ABC\" , \"Numbers\" : { \"One\" : 1, \"Two\" : 2 } }";
            bool expectedResponse = true;

            WebService webService = new WebService();
            bool actual = webService.IsValidJson(input);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void InvalidatesInvalidJson_MissingClosingQuote()
        {
            String input = "{ \"age\" :20, \"Car\": \"ABC , \"Numbers\" : { \"One\" : 1, \"Two\" : 2 } }";
            bool expectedResponse = false;

            WebService webService = new WebService();
            bool actual = webService.IsValidJson(input);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void InvalidatesInvalidJson_MissingClosingBrace()
        {
            String input = "{ \"age\" :20, \"Car\": \"ABC\" , \"Numbers\" : { \"One\" : 1, \"Two\" : 2 }";
            bool expectedResponse = false;

            WebService webService = new WebService();
            bool actual = webService.IsValidJson(input);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void InvalidatesInvalidJson_MissingKey()
        {
            String input = "{ \"age\" :20, : \"ABC\" , \"Numbers\" : { \"One\" : 1, \"Two\" : 2 } }";
            bool expectedResponse = false;

            WebService webService = new WebService();
            bool actual = webService.IsValidJson(input);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void InvalidatesInvalidJson_MissingValue()
        {
            String input = "{ \"age\" :20, \"Car\": \"ABC\" , \"Numbers\" : { \"One\" :, \"Two\" : 2 } }";
            bool expectedResponse = false;

            WebService webService = new WebService();
            bool actual = webService.IsValidJson(input);
            Assert.AreEqual(expectedResponse, actual);
        }

        [TestMethod]
        public void IsNotReturningInvalidJson()
        {
            String url = "http://echo.jsontest.com/one/two"; // http://echo.jsontest.com/key/value/one/two
            String expectedResponse =
                "{\"one\": \"two\"}\n";

            WebService webService = new WebService();
            String actual = webService.GetResponse(url);
            Assert.AreEqual(expectedResponse, actual);
        }
    }
}
