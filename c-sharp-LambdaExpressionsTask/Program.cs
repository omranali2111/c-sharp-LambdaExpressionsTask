﻿using c_sharp_LambdaExpressionsTask;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {
            new Student("asad", 20, "Male", 3.8),
            new Student("mlak", 22, "Female", 3.5),
            new Student("ali", 21, "Male", 3.2),
            new Student("Emily", 19, "Female", 3.9),
            new Student("Ali", 24, "Male", 3),
            new Student("mnar", 23, "Female", 3.6),
            new Student("salim", 26, "Male", 3.7),

         };

        //disply all student from list
        //foreach (var student in list)
        //{
        //    console.writeline(student);
        //}

        //Filter and display male students with a GPA greater than 3.5.

        var maleGPA = list.Where(x => x.GPA > 3.5&&x.Gender=="Male");
           

        foreach (Student name in maleGPA)
        {
            Console.WriteLine(name);
        }

        //Find the average GPA of all female students.

        var averageGPA = list.Where(x => x.Gender == "Female").Average(x => x.GPA);                            
        Console.WriteLine(averageGPA);

        //Display the names of the top three students with the highest GPA.

        var topThree= list.OrderByDescending(student => student.GPA)
                                  .Take(3)
                                  .Select(student => student.Name);

        Console.WriteLine("Top three students with the highest GPA:");
        foreach (string name in topThree)
        {
            Console.WriteLine(name);
        }




    }
}