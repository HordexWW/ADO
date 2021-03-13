using ADOTask1.TriangleLogic;
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
            TriangleManager triangleManager = new TriangleManager();

            //точки на одной линии
            Triangle t1 = triangleManager.Create(new Point(4, 6), new Point(7, 5), new Point(13, 3));
            Console.WriteLine(t1);

            //валидные данные, считывается из файла
            Triangle t2 = triangleManager.Create("input_triangle1.txt");
            Console.WriteLine(t2);

            //точки на одной линии, считывается из файла
            Triangle t3 = triangleManager.Create("input_triangle2.txt");
            Console.WriteLine(t3);

            //невалидное количество координат, считывается из файла
            Triangle te = triangleManager.Create("input_triangle3.txt");
            Console.WriteLine(te);

            //обычный треугольник
            Triangle t4 = new Triangle(new Point(0, 3), new Point(0, 0), new Point(4, 0));
            Console.WriteLine(t4);

            Console.WriteLine("Сторона AB: " + t4.GetLengthOfSide(Sides.AB));
            Console.WriteLine("Сторона BC: " + t4.GetLengthOfSide(Sides.BC));
            Console.WriteLine("Сторона AC: " + t4.GetLengthOfSide(Sides.AC));

            Console.WriteLine($"Периметр: {t4.GetPerimeter()}");
            Console.WriteLine($"Площадь: {t4.GetSquare()}");

            Console.ReadKey();
        }
    }
}
