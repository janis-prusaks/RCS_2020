using System;

namespace Day5
{
    class Program
    {









        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();

            switch (inp)
            {
                case "1":
                    Task3_1();
                    break;

                case "2":
                    Task3_2();
                    break;

                case "3":
                    Task3_3();
                    break;

                case "4":
                    Task3_4();
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
    }
}
