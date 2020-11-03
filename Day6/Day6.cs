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
                    //te varēja for ciklu
                    break;

                case "2":
                    Console.WriteLine("Ievadi vārdu: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Ievadi uzvārdu: ");
                    string surname = Console.ReadLine();
                    Task2.PrintMyName(name, surname);                        ;
                    break;

                case "3":
                    Task3.PrintNameSurname();
                    break;

                case "4":
                    Console.WriteLine("Ievadi skaitli n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Faktoriāls no {n} ir {Task4.Factorial(n)}");
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }

    }
}
