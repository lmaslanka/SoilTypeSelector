namespace SoilTypeSelector.SoilTypeLibrary
{
    using System;
    using SoilTypeSelector.PolygonLibrary;

    public class SoilType
    {
        public string Name { get; set; }
        public TernaryCoordinate[] Coordinates { get; set; }

        private readonly PolygonTools polyTools;

        public string GetSoilType(TernaryCoordinate coord)
        {
            var samplePoint = ConvertTernaryToCartesianCoordinates(coord);
            
            foreach (var soilType in SoilTypeValues.SoilTypes)
            {
                var poly = soilType.GetPolygon();
                if (polyTools.InsidePolygon(poly, poly.Length, samplePoint) == 0)
                {
                    return soilType.Name;
                }
            }

            return "N/A";
        }

        private Point[] GetPolygon()
        {
            int index = 0;
            Point[] polygon = new Point[Coordinates.Length];
            foreach (var coordinate in Coordinates)
            {
                polygon[index] = ConvertTernaryToCartesianCoordinates(coordinate);
                index++;
            }

            return polygon;
        }

        private Point ConvertTernaryToCartesianCoordinates(TernaryCoordinate coord)
        {
            double xCoord = (1.0D / 2.0D) * ((2.0D * coord.Silt + coord.Clay) / (coord.Sand + coord.Silt + coord.Clay));
            double yCoord = (Math.Sqrt(3.0D) / 2.0D) * (coord.Clay / (coord.Sand + coord.Silt + coord.Clay));

            return new Point() { x = xCoord, y = yCoord };
        }

        public SoilType()
        {
            this.polyTools = new PolygonTools();
        }
    }
}
