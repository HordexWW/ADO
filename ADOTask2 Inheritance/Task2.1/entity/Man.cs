using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask2_Inheritance.Task2._1.entity
{
    class Man
    {
        private string name;
        private int age;
        private double height;
        private double weight;

        public Man(string name, int age, double height, double weight)
        {
            if (name == null || name == "") throw new ArgumentException("Имя не должно быть пустым!");
            if (age < 0) throw new ArgumentException("Возраст должен быть больше нуля!");
            if (height < 0) throw new ArgumentException("Рост должен быть больше нуля!");
            if (weight < 0) throw new ArgumentException("Вес должен быть больше нуля!");

            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
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

        public double Height
        {
            get => this.height;
            set
            {
                if (value < 0) throw new ArgumentException("Рост должен быть больше нуля!");
                this.height = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 0) throw new ArgumentException("Вес должен быть больше нуля!");
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return "\nMan {name = \'" + this.name + "\'" + 
                ", age = " + this.age + 
                ", height = " + this.height + 
                ", weight = " + this.weight + "}";
        }





    }
}
