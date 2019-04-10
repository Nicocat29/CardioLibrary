using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.test
{
    [TestClass]
    public class Datacardio1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int battiticardiaci = 60;
            string asp = "Normale";
            string ritorno = CardioLibrary.DataCardio.ValoriFrequenza(battiticardiaci);
            Assert.AreEqual(asp, ritorno);
        }
    }
}
