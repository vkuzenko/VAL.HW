using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    class LandArea
    {

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public List<Point> Points { get; set; }

        public LandArea()
        {
            Points = new List<Point>();
        } 

        private long CalculateArea(List<Point> points)
        {
            long landArea = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;
                long par1 = points[i].X;
                long par2_1 = points[nextIndex].Y;
                long par2_2 = points[prevIndex].Y;
                long tempLandArea = landArea;
                landArea += par1 * (par2_1 - par2_2);
            }
            long result = (long)Math.Abs(landArea / 2);
            return result;
        }

        public long GetLandArea()
        {
            return CalculateArea(Points);
        }
    }
}
