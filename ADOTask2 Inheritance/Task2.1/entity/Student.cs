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
            this.yearOfAdmission = yearOfAdmission;
            this.course = course;
            this.group = group;
        }

        public int YearOfAdmission
        {
            get => this.yearOfAdmission;
            set => this.yearOfAdmission = value;
        }

        public int Course
        {
            get => this.course;
            set => this.course = value;
        }

        public int Group
        {
            get => this.group;
            set => this.group = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
