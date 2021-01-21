using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccessoryTestClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.checkType("R"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.changeType("R"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.checkValue(50000));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.changeValue(50000));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.checkQuantity(10));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Accessory accessory = new Accessory();
            Assert.IsTrue(accessory.changeQuantity(10));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Accessory accessory = new Accessory();
            Assert.AreEqual(accessory.whatType(), "Резистор");
        }
    }
}
