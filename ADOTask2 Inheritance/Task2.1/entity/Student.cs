using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTask2_Inheritance.Task2._1.entity
{
    class Student : Man
    {
        private int yearOfAdmission;
        private int course;
        private int group;

        public Student(string name, int age, double height, double weight, int yearOfAdmission, int course, int group)
            : base(name, age, height, weight)
        {
            if (yearOfAdmission < 0) throw new ArgumentException("Год поступления должен быть больше нуля!");
            if (course < 0) throw new ArgumentException("Курс должен быть больше нуля!");
            if (group < 0) throw new ArgumentException("Номер группы должен быть больше нуля!");

            this.yearOfAdmission = yearOfAdmission;
            this.course = course;
            this.group = group;
        }

        public int YearOfAdmission
        {
            get => this.yearOfAdmission;
            set
            {
                if (value < 0) throw new ArgumentException("Год поступления должен быть больше нуля!");
                this.yearOfAdmission = value;
            }
        }

        public int Course
        {
            get => this.course;
            set
            {
                if (value < 0) throw new ArgumentException("Курс должен быть больше нуля!");
                this.course = value;
            }
        }

        public int Group
        {
            get => this.group;
            set
            {
                if (value< 0) throw new ArgumentException("Номер группы должен быть больше нуля!");
                this.course = value;
            }
        }

        public override string ToString()
        {
            return " Man {name = \'" + this.Name + "\'" +
                ", age = " + this.Age +
                ", height = " + this.Height +
                ", weight = " + this.Weight + 
                ", year of admission = " + this.yearOfAdmission +
                ", course = " + this.course +
                ", group = " + this.group +
                "}";
        }
    }
}
