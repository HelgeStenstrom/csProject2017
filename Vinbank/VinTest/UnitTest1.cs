using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vinbank;

namespace VinTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Setup
            WineCellar wineCellar = new WineCellar();
            Wine wine = new Wine();

            // Exercise
            wineCellar.Add(wine);

            // Verify


        }
    }
}
