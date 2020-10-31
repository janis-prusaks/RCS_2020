using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task3
    {
        public static string GetNameSurname()
        {
            Console.WriteLine("Ievadi vārdu un uzvārdu");
            return Console.ReadLine();
            
        }

        public static void PrintNameSurname()
        {
            Console.WriteLine(GetNameSurname());
        }

    }
}
