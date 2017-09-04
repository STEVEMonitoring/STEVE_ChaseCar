using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using STEVE_Chase_Car.Code;

namespace Tests_STEVE_Chase_Car
{
    [TestClass]
    public class UnitTest_DataField
    {
        [TestMethod]
        public void ConstructorGenerateDefaultInstance()
        {
            Assert.IsNotNull(new DataField(new byte[8]));
        }

        [TestMethod]
        public void ReturnsFirstByte()
        {
            Assert.AreEqual<uint>(
                0x42,
                (new DataField(new byte[8] {0x42, 0, 0, 0, 0, 0, 0, 0 }).get_value(0, 8))
                );
        }
    }
}
