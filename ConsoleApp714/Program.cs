﻿using System;

namespace ConsoleApp714
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }

        class ProjectManager : Employee
        {
            public string ProjectName;

        }

        class Developer : Employee
        {
            private string ProgrammingLanguage;

        }



    }
}
