using Microsoft.VisualStudio.TestTools.UnitTesting;
using Winecellar;

namespace VinTest
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void AddWine()
        {
            // Setup
            WineManager wineManager = new WineManager();
            Wine wine = new Wine();

            // Exercise
            wineManager.AddWine(wine);
            wineManager.AddWine(wine);

            // Verify
            Assert.AreEqual(2, wineManager.WineCount);
        }

        [TestMethod]
        public void RemoveWine()
        {
            // Setup
            WineManager wineManager = new WineManager();
            Wine wine1 = new Wine();
            wine1.WineName = "ett";
            Wine wine2 = new Wine();
            wine2.WineName = "två";
            wineManager.AddWine(wine1);
            wineManager.AddWine(wine2);

            // Exercise
            wineManager.RemoveWine(0);

            // Verify
            Assert.AreEqual(1, wineManager.WineCount);
            Assert.AreSame("två", wineManager.GetWine(0).WineName);
        }

        [TestMethod]
        public void ChangeWine()
        {
            // Setup
            WineManager wineManager = new WineManager();
            Wine wine1 = new Wine();
            wine1.WineName = "ett";
            Wine wine2 = new Wine();
            wine2.WineName = "två";
            wineManager.AddWine(wine1);

            // Exercise
            var result = wineManager.ChangeWine(wine2, 0);

            // Verify
            Assert.IsTrue(result);
            Assert.AreSame("två", wineManager.GetWine(0).WineName);
        }
    }
}
