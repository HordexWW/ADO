using ADOTask2_Inheritance.Task2._1.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("John", 18, 180, 80);

            Console.WriteLine(man);
        }
    }
}
