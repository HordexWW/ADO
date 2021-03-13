using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask1
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }
        public static double GetLengthBetween(Point first, Point second)
        {
            return Math.Sqrt(
                Math.Pow(second.X - first.X, 2) + 
                Math.Pow(second.Y - first.Y, 2));
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public static bool IfOntheLine(Point a, Point b, Point c)
        {
            if ((c.X - a.X) / (b.X - a.X) == (c.Y - a.Y) / (b.Y - a.Y))
            {
                return false;
            }
            return true;
        }
        public static bool IfOntheLine(double ax, double ay, double bx, double by, double cx, double cy)
        {
            if ((cx - ax) / (bx - ax) == (cy - ay) / (by - ay))
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return $"({this.x}; {this.y})";
        }
    }
}
