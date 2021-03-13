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
        private Point p1;
        private Point p2;
        private Point p3;
        public Triangle(Point p1, Point p2, Point p3)
        {
            if (ValidatePoints(p1, p2, p3))
            {
                this.p1 = new Point(p1);
                this.p2 = new Point(p2);
                this.p3 = new Point(p3);
            }
            else
            {
                try
                {
                    throw new ArgumentException("Треугольник вырожденный, создан треугольник по умолчанию:");
                }
                catch(ArgumentException ae){
                    SetDefaultTriangle();
                    Console.WriteLine(ae.Message);
                    Console.WriteLine(this);
                }
            }
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            if (ValidatePoints(x1, y1, x2, y2, x3, y3))
            {
                p1 = new Point(x1, y1);
                p2 = new Point(x2, y2);
                p3 = new Point(x3, y3);
            }
            else
            {
                try
                {
                    throw new ArgumentException("Треугольник вырожденный, создан треугольник по умолчанию:");
                }
                catch (ArgumentException ae)
                {
                    SetDefaultTriangle();
                    Console.WriteLine(ae.Message);
                    Console.WriteLine(this);
                }
            }
            
        }
        public Triangle(string filepath)
        {
            char[] splitter = { ' ', '\n', '\t', '\r'};
            string fileInfo;
            using (StreamReader input = new StreamReader(filepath))
            {
                fileInfo = input.ReadToEnd();
            }
            string[] coords = fileInfo.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            Point[] points = new Point[3];
            
            if (coords.Length != 6)
            {
                throw new ArgumentException($"Недопустимое количество параметров в файле {filepath} ! Необходимо 6!");
            }

            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(int.Parse(coords[i * 2]), int.Parse(coords[i * 2 + 1]));
            }
            if (ValidatePoints(points[0], points[1], points[2]))
            {
                p1 = new Point(points[0]);
                p2 = new Point(points[1]);
                p3 = new Point(points[2]);
            }
            else
            {
                try
                {
                    throw new ArgumentException("Треугольник вырожденный!");
                }
                catch(ArgumentException ae)
                {
                    SetDefaultTriangle();
                    Console.WriteLine(ae.Message);
                    Console.WriteLine(this);
                }
            }
            
        }
        private void SetDefaultTriangle()
        {
            this.p1 = new Point(0, 0);
            this.p2 = new Point(1, 0);
            this.p3 = new Point(0, 1);
        }
        public double GetPerimeter()
        {
            return this[Sides.AB] + this[Sides.BC] + this[Sides.AC];
        }

        public double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            double square =
                Math.Sqrt(p *
                (p - this[Sides.AB]) *
                (p - this[Sides.BC]) *
                (p - this[Sides.AC]));
            return square;
        }
        /**
         * Индексатор для получения длины стороны
         */
        public double this[Sides side]
        {
            get
            {
                if (side == Sides.AB)
                    return Point.GetLengthBetween(p1, p2);
                else if (side == Sides.BC)
                    return Point.GetLengthBetween(p2, p3);
                else 
                    return Point.GetLengthBetween(p1, p3);
            }
        }
        
        private static bool ValidatePoints(Point p1, Point p2, Point p3)
        {
            if ((p3.X - p1.X) / (p2.X - p1.X) == (p3.Y - p1.Y) / (p2.Y - p1.Y))
            {
                return false;
            }
            return true;
        }
        private static bool ValidatePoints(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            if((x3 - x1) / (x2 - x1) == (y3 - y1) / (y2 - y1))
            {
                return false;
            }
            return true;
        }
        public Point P1
        { 
            get => new Point(p1); 
            set
            {
                if (ValidatePoints(value, p2, p3))
                {
                    p1 = new Point(value);
                }
            }
        }
        public Point P2 
        { 
            get => new Point(p2);
            set
            {
                if (ValidatePoints(p1, value, p3))
                {
                    p2 = new Point(value);
                }
            }
        }
        public Point P3 
        { 
            get => new Point(p3);
            set
            {
                if (ValidatePoints(p1, p2, value))
                {
                    p3 = new Point(value);
                }
            }
        }
        public override string ToString()
        {
            return $"Triangle [{this.p1}, {this.p2}, {this.p3}]";
        }
    }
}
