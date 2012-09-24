using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoilTypeSelector.SoilTypeLibrary;

namespace SoilTypeSelector.Tests
{
    [TestClass]
    public class SoilTypeSelectorTests
    {
        private TernaryCoordinate ClaySamplePoint = new TernaryCoordinate { Sand = 15, Silt = 15, Clay = 70 };
        private TernaryCoordinate SandyClaySamplePoint = new TernaryCoordinate { Sand = 50, Silt = 5, Clay = 45 };

        private SoilType soil;

        [TestInitialize]
        public void InitializeTest()
        {
            soil = new SoilType();
        }

        [TestMethod]
        public void GetType_ProvidePoint_GetBackSoilTypeAsClay()
        {
            Assert.IsTrue(soil.GetSoilType(ClaySamplePoint) == "Clay");
        }

        [TestMethod]
        public void GetType_ProvidePoint_GetBackSoilTypeAsSandyClay()
        {
            Assert.IsTrue(soil.GetSoilType(SandyClaySamplePoint) == "Sandy Clay");
        }
    }
}
