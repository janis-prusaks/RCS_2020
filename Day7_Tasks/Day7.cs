using System;

namespace Day7_Tasks
{
    class Day7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":                    
                    Console.WriteLine("skat. prog. TicTacToe");
                    Console.WriteLine("--------------------");
                    break;

                case "2":
                    Task2.PrintNameSurname("Jānis Prusaks");                                        
                    Task2.PrintNameSurname("Jānis", "Prusaks");
                    Task2.PrintNameAge("Jānis", 44);
                    Task2.PrintNameAge("Jānis");
                    
                    break;

                case "3":
                    int[] array = { 1, 2, 3, 4, 5 };
                    string[] array2 = { "a", "b", "c" };
                    Task3.PrintArrayValues(array);
                    Task3.PrintArrayValues(array2);                  

                    break;

                case "4":
                    string[] arrayNames = {"Jānis", "", "Pēteris", "Antons", "", "Andris"};
                    Task3.PrintArrayValues(arrayNames);
                    //Task4.GetNonEmtyArray(arrayNames);
                    Task3.PrintArrayValues(arrayNames);

                    break;

                case "5":                   
                    Console.WriteLine(Task5.CalculateSum(5, 4));
                    Console.WriteLine(Task5.CalculateSum(1, 3));

                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }
    }
}
