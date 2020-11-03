using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Tasks
{
    class Task2
    {
        public static void PrintNameSurname(string name)
        {
            Console.WriteLine(name);
        }

        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }

        public static void PrintNameAge(string name, int age = 99)
        {
            Console.WriteLine(name + ", " + age + "  gadi");
        }


    }
}
