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

            try
            {
                Man man = new Man("awda", 18, 180, 80);
                Student student = new Student("st1", 20, 170, 70, -2018, 3, 341);

                Console.WriteLine(man);
                Console.WriteLine(student);
            }
            catch( ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
