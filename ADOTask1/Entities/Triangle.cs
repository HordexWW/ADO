using ADOTask1.TriangleLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask1
{
    public enum Sides
    {
        AB, BC, AC
    }
    class Triangle
    {
        private Point a;
        private Point b;
        private Point c;
        public Triangle(Point a, Point b, Point c)
        {
            this.a = new Point(a);
            this.b = new Point(b);
            this.c = new Point(c);
        }
        public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
        {
            a = new Point(ax, ay);
            b = new Point(bx, by);
            c = new Point(cx, cy);
        }
        
        public double GetPerimeter()
        {
            return GetLengthOfSide(Sides.AB) + 
                GetLengthOfSide(Sides.BC) + 
                GetLengthOfSide(Sides.AC);
        }

        public double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            double square =
                Math.Sqrt(p *
                (p - GetLengthOfSide(Sides.AB)) *
                (p - GetLengthOfSide(Sides.BC)) *
                (p - GetLengthOfSide(Sides.AC)));
            return square;
        }
        public double GetLengthOfSide(Sides side)
        {
            if (side == Sides.AB)
                return Point.GetLengthBetween(a, b);
            else if (side == Sides.BC)
                return Point.GetLengthBetween(b, c);
            else 
                return Point.GetLengthBetween(a, c);
        }
        public Point A
        { 
            get => new Point(a); 
            set
            {
                if (Point.IfOntheLine(value, b, c))
                {
                    a = new Point(value);
                }
            }
        }
        public Point B 
        { 
            get => new Point(b);
            set
            {
                if (Point.IfOntheLine(a, value, c))
                {
                    b = new Point(value);
                }
            }
        }
        public Point C 
        { 
            get => new Point(c);
            set
            {
                if (Point.IfOntheLine(a, b, value))
                {
                    c = new Point(value);
                }
            }
        }
        public override string ToString()
        {
            return $"Triangle [{this.a}, {this.b}, {this.c}]\n";
        }
    }
}
