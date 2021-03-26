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
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        } 

        public double Height
        {
            get => this.height;
            set => this.height = value;
        }

        public double Weight
        {
            get => this.weight;
            set => this.weight = value;
        }

        public override string ToString()
        {
            return " Man {name = \'" + this.name + "\'" + 
                ", age = " + this.age + 
                ", height = " + this.height + 
                ", weight = " + this.weight + "}";
        }





    }
}
