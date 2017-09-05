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

        // Tests for get_value( )
        [TestMethod]
        [TestCategory("get_value")]
        public void ReturnsFirstByte()
        {
            Assert.AreEqual<uint>(
                0x42,
                (new DataField(new byte[8] {0x42, 0, 0, 0, 0, 0, 0, 0 }).get_value(0, 8))
                );
        }

        [TestMethod]
        [TestCategory("get_value")]
        public void ReturnsLastByte()
        {
            Assert.AreEqual<uint>(
                0x42,
                (new DataField(new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0x42 }).get_value(64 - 8, 8))
                );
        }

        [TestMethod]
        [TestCategory("get_value")]
        public void ReturnsValueSpanningMultipleBytes()
        {
            Assert.AreEqual<uint>(
                0xFF,
                (new DataField(new byte[8] { 0, 0xF0, 0x0F, 0, 0, 0, 0, 0 }).get_value(12, 8))
                );
        }

        [TestMethod]
        [TestCategory("get_value")]
        public void ReturnsOneSetBit()
        {
            Assert.AreEqual<uint>(
                1,
                (new DataField(new byte[8] { 0, 0, 0, 0x08, 0, 0, 0, 0x42 }).get_value(27, 1))
                );
        }

        [TestMethod]
        [TestCategory("get_value")]
        public void ReturnsOneResetBit()
        {
            Assert.AreEqual<uint>(
                0,
                (new DataField(new byte[8] { 0, 0, 0, 0x08, 0, 0, 0, 0x42 }).get_value(28, 1))
                );
        }
    }
}
