using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using Potegowanie;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PotegowanieMalychLiczb()
        {
            var testObject = new Iteracyjny();
            testObject.podstawa = 2;
            testObject.wykladnik = 2;
            Assert.AreEqual(testObject.POW(), 4);
        }

        [TestMethod]
        public void PotegowanieZera()
        {
            var testObject = new Iteracyjny();
            testObject.podstawa = 0;
            testObject.wykladnik = 2;
            Assert.AreEqual(testObject.POW(), 0);
        }


        [TestMethod]
        public void PotegowanieDuzyWykladnik()
        {
            var testObject = new Iteracyjny();
            testObject.podstawa = 2;
            testObject.wykladnik = 20;
            Assert.AreEqual(testObject.POW(), 1048576);
        }

        [TestMethod]
        public void PotegowanieZeraDoZera()
        {
            var testObject = new Iteracyjny();
            testObject.podstawa = 0;
            testObject.wykladnik = 0;
            Assert.AreEqual(testObject.POW(), 1);
        }


    }
}
