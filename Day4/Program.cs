using System;

namespace Day4
{
    class Program
    {
        static void Task4_1()
        {
            string[] names = { "Ilze", "Līva", "Rūta" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }

        static void Task4_2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };
            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
        }






        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();

            switch (inp)
            {
                case "1":
                    Task4_1();
                    break;

                case "2":
                    Task4_2();
                    break;

                case "3":
                    //Task3_3();
                    break;

                case "4":
                    //Task3_4();
                    break;

                case "5":
                    //Task3_5();
                    break;

                case "6":
                    //Task3_4();
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }
    }
}
