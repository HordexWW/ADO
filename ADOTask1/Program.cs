using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle t1 = new Triangle(new Point(4, 6), new Point(7, 5), new Point(13, 3));
            Triangle t1 = new Triangle("input_triangle1.txt");
            Console.WriteLine(t1);
            Triangle t2 = new Triangle(new Point(0, 3), new Point(0, 0), new Point(4, 0));

            Console.WriteLine(t2);
            Console.WriteLine("Сторона AB: " + t2[Sides.AB]);
            Console.WriteLine("Сторона BC: " + t2[Sides.BC]);
            Console.WriteLine("Сторона AC: " + t2[Sides.AC]);
            
            Console.WriteLine($"Периметр: {t2.GetPerimeter()}");
            Console.WriteLine($"Площадь: {t2.GetSquare()}");

            Console.ReadKey();
        }
    }
}
