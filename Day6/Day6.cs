using System;

namespace Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":
                    Task1.MultipleGreetings();
                    break;

                case "2":
                    Task2.PrintMyName("janis", "prusaks");                        ;
                    break;

                case "3":
                    Task3.PrintNameSurname();
                    break;
                
                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }

    }
}
