using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoilTypeSelector.SoilTypeLibrary;

namespace SoilTypeSelector.Tests
{
    [TestClass]
    public class SoilTypeSelectorTests
    {
        private TernaryCoordinate ClaySamplePoint = new TernaryCoordinate { Sand = 15, Silt = 15, Clay = 70 };
        private TernaryCoordinate SiltyClaySamplePoint = new TernaryCoordinate { Sand = 5, Silt = 45, Clay = 50 };
        private TernaryCoordinate SandyClaySamplePoint = new TernaryCoordinate { Sand = 50, Silt = 5, Clay = 45 };
        private TernaryCoordinate ClayLoamSamplePoint = new TernaryCoordinate { Sand = 30, Silt = 35, Clay = 35 };
        private TernaryCoordinate SiltyClayLoamSamplePoint = new TernaryCoordinate { Sand = 10, Silt = 55, Clay = 35 };
        private TernaryCoordinate SandyClayLoamSamplePoint = new TernaryCoordinate { Sand = 55, Silt = 15, Clay = 30 };
        private TernaryCoordinate LoamSamplePoint = new TernaryCoordinate { Sand = 40, Silt = 40, Clay = 20 };
        private TernaryCoordinate SiltLoamSamplePoint = new TernaryCoordinate { Sand = 20, Silt = 65, Clay = 15 };
        private TernaryCoordinate SiltSamplePoint = new TernaryCoordinate { Sand = 5, Silt = 90, Clay = 5 };
        private TernaryCoordinate SandyLoamSamplePoint = new TernaryCoordinate { Sand = 65, Silt = 25, Clay = 10 };
        private TernaryCoordinate LoamySandSamplePoint = new TernaryCoordinate { Sand = 80, Silt = 15, Clay = 5 };
        private TernaryCoordinate SandSamplePoint = new TernaryCoordinate { Sand = 90, Silt = 5, Clay = 5 };

        private TernaryCoordinate ClayEdgeSamplePoint = new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 };

        private SoilType soil;

        [TestInitialize]
        public void InitializeTest()
        {
            soil = new SoilType();
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsClay()
        {
            Assert.IsTrue(soil.GetSoilType(ClaySamplePoint) == "Clay");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSiltyClay()
        {
            Assert.IsTrue(soil.GetSoilType(SiltyClaySamplePoint) == "Silty Clay");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSandyClay()
        {
            Assert.IsTrue(soil.GetSoilType(SandyClaySamplePoint) == "Sandy Clay");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsClayLoam()
        {
            Assert.IsTrue(soil.GetSoilType(ClayLoamSamplePoint) == "Clay Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSiltyClayLoam()
        {
            Assert.IsTrue(soil.GetSoilType(SiltyClayLoamSamplePoint) == "Silty Clay Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSandyClayLoam()
        {
            Assert.IsTrue(soil.GetSoilType(SandyClayLoamSamplePoint) == "Sandy Clay Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsLoam()
        {
            Assert.IsTrue(soil.GetSoilType(LoamSamplePoint) == "Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSiltLoam()
        {
            Assert.IsTrue(soil.GetSoilType(SiltLoamSamplePoint) == "Silt Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSilt()
        {
            Assert.IsTrue(soil.GetSoilType(SiltSamplePoint) == "Silt");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSandyLoam()
        {
            Assert.IsTrue(soil.GetSoilType(SandyLoamSamplePoint) == "Sandy Loam");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsLoamySand()
        {
            Assert.IsTrue(soil.GetSoilType(LoamySandSamplePoint) == "Loamy Sand");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointInsideType_GetBackSoilTypeAsSand()
        {
            Assert.IsTrue(soil.GetSoilType(SandSamplePoint) == "Sand");
        }

        [TestMethod]
        public void GetSoilType_ProvidePointOnEdgeOfType_GetBackSoilTypeAsClay()
        {
            var result = soil.GetSoilType(ClayEdgeSamplePoint);
            Assert.IsTrue(result == "Clay Loam");
        }
    }
}
