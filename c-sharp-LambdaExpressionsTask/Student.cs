using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_LambdaExpressionsTask
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, string gender, double gpa)
        {
            Name = name;
            Age = age;
            Gender = gender;
            GPA = gpa;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}, GPA: {GPA}";
        }
    }
}
