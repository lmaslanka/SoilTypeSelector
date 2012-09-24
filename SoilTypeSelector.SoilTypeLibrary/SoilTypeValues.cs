namespace SoilTypeSelector.SoilTypeLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SoilTypeValues
    {
        public static SoilType Clay = new SoilType
        {
            Name = "Clay",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 0, Silt = 0, Clay = 100 },
                new TernaryCoordinate { Sand = 0, Silt = 40, Clay = 60 },
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 },
                new TernaryCoordinate { Sand = 45, Silt = 15, Clay = 40 },
                new TernaryCoordinate { Sand = 45, Silt = 0, Clay = 55 },
                new TernaryCoordinate { Sand = 0, Silt = 0, Clay = 100 }
            }
        };

        public static SoilType SiltyClay = new SoilType
        {
            Name = "Silty Clay",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 0, Silt = 40, Clay = 60 },
                new TernaryCoordinate { Sand = 0, Silt = 60, Clay = 40 },
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 }
            }
        };

        public static SoilType SandyClay = new SoilType
        {
            Name = "Sandy Clay",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 45, Silt = 0, Clay = 55 },
                new TernaryCoordinate { Sand = 45, Silt = 20, Clay = 35 },
                new TernaryCoordinate { Sand = 65, Silt = 0, Clay = 45 },
                new TernaryCoordinate { Sand = 45, Silt = 0, Clay = 55 }
            }
        };

        public static SoilType ClayLoam = new SoilType
        {
            Name = "Clay Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 45, Silt = 15, Clay = 40 },
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 },
                new TernaryCoordinate { Sand = 20, Silt = 72.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 45, Silt = 27.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 45, Silt = 15, Clay = 40 }
            }
        };

        public static SoilType SiltyClayLoam = new SoilType
        {
            Name = "Silty Clay Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 },
                new TernaryCoordinate { Sand = 0, Silt = 60, Clay = 40 },
                new TernaryCoordinate { Sand = 20, Silt = 52.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 45, Silt = 32.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 }
            }
        };

        public static SoilType SandyClayLoam = new SoilType
        {
            Name = "Sandy Clay Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 65, Silt = 0, Clay = 35 },
                new TernaryCoordinate { Sand = 45, Silt = 20, Clay = 35 },
                new TernaryCoordinate { Sand = 45, Silt = 27.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 52.5, Silt = 27.5, Clay = 20 },
                new TernaryCoordinate { Sand = 80, Silt = 0, Clay = 20 },
                new TernaryCoordinate { Sand = 20, Silt = 40, Clay = 40 },
                new TernaryCoordinate { Sand = 65, Silt = 0, Clay = 35 }
            }
        };

        public static SoilType Loam = new SoilType
        {
            Name = "Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 45, Silt = 27.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 22.5, Silt = 50, Clay = 27.5 },
                new TernaryCoordinate { Sand = 42.5, Silt = 50, Clay = 7.5 },
                new TernaryCoordinate { Sand = 52.5, Silt = 40, Clay = 7.5 },
                new TernaryCoordinate { Sand = 52.5, Silt = 27.5, Clay = 20 },
                new TernaryCoordinate { Sand = 45, Silt = 27.5, Clay = 27.5 }
            }
        };

        public static SoilType SiltLoam = new SoilType
        {
            Name = "Silt Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 22.5, Silt = 50, Clay = 27.5 },
                new TernaryCoordinate { Sand = 0, Silt = 72.5, Clay = 27.5 },
                new TernaryCoordinate { Sand = 0, Silt = 87.5, Clay = 12.5 },
                new TernaryCoordinate { Sand = 7.5, Silt = 80, Clay = 12.5 },
                new TernaryCoordinate { Sand = 20, Silt = 80, Clay = 0 },
                new TernaryCoordinate { Sand = 50, Silt = 50, Clay = 0 },
                new TernaryCoordinate { Sand = 22.5, Silt = 50, Clay = 27.5 }
            }
        };

        public static SoilType Silt = new SoilType
        {
            Name = "Silt",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 7.5, Silt = 80, Clay = 12.5 },
                new TernaryCoordinate { Sand = 0, Silt = 87.5, Clay = 12.5 },
                new TernaryCoordinate { Sand = 0, Silt = 100, Clay = 0 },
                new TernaryCoordinate { Sand = 20, Silt = 80, Clay = 0 },
                new TernaryCoordinate { Sand = 7.5, Silt = 80, Clay = 12.5 }
            }
        };

        public static SoilType SandyLoam = new SoilType
        {
            Name = "Sandy Loam",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 80, Silt = 0, Clay = 20 },
                new TernaryCoordinate { Sand = 52.5, Silt = 27.5, Clay = 20 },
                new TernaryCoordinate { Sand = 52.5, Silt = 40, Clay = 7.5 },
                new TernaryCoordinate { Sand = 42.5, Silt = 50, Clay = 7.5 },
                new TernaryCoordinate { Sand = 50, Silt = 50, Clay = 0 },
                new TernaryCoordinate { Sand = 70, Silt = 30, Clay = 0 },
                new TernaryCoordinate { Sand = 85, Silt = 0, Clay = 15 },
                new TernaryCoordinate { Sand = 80, Silt = 0, Clay = 20 }
            }
        };

        public static SoilType LoamySand = new SoilType
        {
            Name = "Loamy Sand",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 85, Silt = 0, Clay = 15 },
                new TernaryCoordinate { Sand = 70, Silt = 30, Clay = 0 },
                new TernaryCoordinate { Sand = 85, Silt = 15, Clay = 0 },
                new TernaryCoordinate { Sand = 90, Silt = 0, Clay = 10 },
                new TernaryCoordinate { Sand = 85, Silt = 0, Clay = 15 }
            }
        };

        public static SoilType Sand = new SoilType
        {
            Name = "Sand",
            Coordinates = new[]
            {
                new TernaryCoordinate { Sand = 90, Silt = 0, Clay = 10 },
                new TernaryCoordinate { Sand = 85, Silt = 10, Clay = 0 },
                new TernaryCoordinate { Sand = 100, Silt = 0, Clay = 0 },
                new TernaryCoordinate { Sand = 90, Silt = 0, Clay = 10 }
            }
        };

        public static IList<SoilType> SoilTypes = new List<SoilType>
        {
            Clay,
            SiltyClay,
            SandyClay,
            ClayLoam,
            SiltyClayLoam,
            SandyClayLoam,
            Loam,
            SiltLoam,
            Silt,
            SandyLoam,
            LoamySand,
            Sand
        };
    }
}
