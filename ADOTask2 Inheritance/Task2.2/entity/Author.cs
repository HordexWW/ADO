using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask2_Inheritance.Task2._2.entity
{
    class Author
    {
        private string name;
        private int age;
        private int birthDate;

        public Author(string name, int age, int birthDate)
        {
            if (age < 0) throw new ArgumentException("Возраст автора должен быть больше нуля!");

            this.name = name;
            this.age = age;
            this.birthDate = birthDate;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value == null || value == "") throw new ArgumentException("Имя не должно быть пустым!");
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0) throw new ArgumentException("Возраст должен быть больше нуля!");
                this.age = value;
            }
        }

        public int BirthDate
        {
            get => this.age;
            set
            {
                if (value < 0) throw new ArgumentException("Год рождения должен быть больше нуля!");
                this.age = value;
            }
        }

        public override string ToString()
        {
            return "\nAuthor {name = \'" + this.name + "\'" +
                ", age = " + this.age +
                ", birth date = " + this.birthDate +
                "}";
        }
    }
}
