using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Winecellar;

namespace VinTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Setup
            WineManager wineCellar = new WineManager();
            Wine wine = new Wine();

            // Exercise
            wineCellar.Add(wine);
            wineCellar.Add(wine);

            // Verify
            Assert.AreEqual(2, wineCellar.WineCount);

        }
    }
}
