using ADOTask2_Inheritance.Task2._1.entity;
using ADOTask2_Inheritance.Task2._2.entity;
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

            // tast 2.1
            try
            {
                Man man = new Man("awda", 18, 180, 80);
                Student student = new Student("student", 20, 170, 70, 2018, 3, 341);

                Console.WriteLine(man);
                Console.WriteLine(student);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            // tast 2.2
            try
            {
                Author author = new Author("Jordan Peterson", 58, 1962);
                Book book = new Book("12 rules for life", 500, "Jordan B. Peterson", new DateTime(2018, 1, 23), new DateTime(2018, 1, 15), author);

                Console.WriteLine(author);
                Console.WriteLine(book);
            }
            catch (ArgumentException ae)
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
