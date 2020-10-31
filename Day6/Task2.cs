using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    {
        public static void PrintMyName(string name, string surname)
        {
            string a = name.Substring(0, 1).ToUpper();
            string b = surname.Substring(0, 1).ToUpper();
            string c = surname.Substring(1, surname.Length-1).ToLower();

            Console.WriteLine(a + ". " + b + c);

        }


    }
}
