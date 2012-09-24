namespace SoilTypeSelector.SoilTypeLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using SoilTypeSelector.PolygonLibrary;

    public class TernaryPlotTools
    {
        public string GetType(double Sand, double Silt, double Clay)
        {
            IList polygons = new List<Point[]>();
            foreach (SoilType soilType in SoilTypeValues.SoilTypes)
            {
                int index = 0;
                Point[] polygon = new Point[soilType.Coordinates.Length];
                foreach (var coordinate in soilType.Coordinates)
                {
                    polygon[index] = ConvertTernaryToCartesianCoordinates(coordinate.Sand, coordinate.Silt, coordinate.Clay);
                    index++;
                }
                polygons.Add(polygon);
            }

            var samplePoint = ConvertTernaryToCartesianCoordinates(Sand, Silt, Clay);

            var polyTools = new PolygonTools();
            foreach (Point[] polygon in polygons)
            {
                if (polyTools.InsidePolygon(polygon, polygon.Length, samplePoint) == 0)
                {
                    return "";
                }
            }

            return "";
        }

        private Point ConvertTernaryToCartesianCoordinates(double a, double b, double c)
        {
            double xCoord = (1 / 2) * ((2 * b + c) / (a + b + c));
            double yCoord = (Math.Sqrt(3) / 2) * (c / (a + b + c));

            return new Point() { x = xCoord, y = yCoord };
        }
    }
}
