using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask1.TriangleLogic
{
    class TriangleManager
    {
        public Triangle Create(Point a, Point b, Point c)
        {
            if(Point.IfOntheLine(a, b, c))
            {
                return new Triangle(a, b, c);
            }
            else
            {
                Console.WriteLine("Треугольник вырожденный, создан треугольник по умолчанию.\n");
                return GetDefaultTriangle();
            }
        }
        public Triangle Create(double ax, double ay, double bx, double by, double cx, double cy)
        {
            if (Point.IfOntheLine(ax, ay, bx, by, cx, cy))
            {
                return new Triangle(ax, ay, bx, by, cx, cy);
            }
            else
            {
                Console.WriteLine("Треугольник вырожденный, создан треугольник по умолчанию.\n");
                return GetDefaultTriangle();
            }
        }
        public Triangle Create(string filePath)
        {
            (Point a, Point b, Point c) points;
            try
            {
                points = GetPointsFromFile(filePath);
                if (Point.IfOntheLine(points.a, points.b, points.c))
                {
                    return new Triangle(points.a, points.b, points.c);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
            }
            
            Console.WriteLine("Треугольник вырожденный, создан треугольник по умолчанию.\n");
            return GetDefaultTriangle();
        }
        private (Point a, Point b, Point c) GetPointsFromFile(string filePath)
        {
            char[] splitter = { ' ', '\n', '\t', '\r' };
            string fileInfo;
            using (StreamReader input = new StreamReader(filePath))
            {
                fileInfo = input.ReadToEnd();
            }
            string[] coords = fileInfo.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            if (coords.Length != 6)
            {
                throw new ArgumentException(
                    $"Недопустимое количество параметров" +
                    $" в файле {filePath} ! Необходимо 6!");
            }
            Point[] points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point(double.Parse(coords[i * 2]), double.Parse(coords[i * 2 + 1]));
            }
            return (points[0], points[1], points[2]);
        }
        private Triangle GetDefaultTriangle()
        {
            return new Triangle(new Point(0, 1), new Point(0, 0), new Point(1, 0));
        }
    }
}
