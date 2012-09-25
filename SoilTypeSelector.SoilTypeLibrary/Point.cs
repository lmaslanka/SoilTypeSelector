namespace SoilTypeSelector.SoilTypeLibrary
{

    public class Point
    {
        public const int Inside = 0;
        public const int Outside = 1;

        public double x { get; set; }
        public double y { get; set; }

        public int InsidePolygon(Point[] polygon, int N)
        {
            int counter = 0;
            int i;
            double xinters;
            Point p1, p2;

            p1 = polygon[0];
            for (i = 1; i <= N; i++)
            {
                p2 = polygon[i % N];
                if (this.y > Min(p1.y, p2.y))
                {
                    if (this.y <= Max(p1.y, p2.y))
                    {
                        if (this.x <= Max(p1.x, p2.x))
                        {
                            if (p1.y != p2.y)
                            {
                                xinters = (this.y - p1.y) * (p2.x - p1.x) / (p2.y - p1.y) + p1.x;
                                if (p1.x == p2.x || this.x <= xinters)
                                    counter++;
                            }
                        }
                    }
                }
                p1 = p2;
            }

            if (counter % 2 == 0)
                return (Outside);
            else
                return (Inside);
        }

        private double Max(double x, double y)
        {
            return x > y ? x : y;
        }

        private double Min(double x, double y)
        {
            return x < y ? x : y;
        }
    }
}
