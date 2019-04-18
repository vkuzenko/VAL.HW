using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    class LandArea
    {
        List<Point> Points { get; set; }

        public LandArea(List<Point> points)
        {
            Points = points;
        }

        private long CalculateArea(List<Point> points, bool isAltAppr)
        {
            long landArea = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;
                long par1 = isAltAppr ? points[i].X : points[i].Y;
                long par2_1 = isAltAppr ? points[nextIndex].Y : points[prevIndex].X;
                long par2_2 = isAltAppr ? points[prevIndex].Y : points[nextIndex].X;
                long tempLandArea = landArea;
                landArea += par1 * (par2_1 - par2_2);
            }
            long result = (long)Math.Abs(landArea / 2);
            return result;
        }

        public long GetLandArea()
        {
            return CalculateArea(this.Points, false);
        }
    }
}
