using System;

namespace Day8
{
    class Day8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":
                    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2 };
                    Console.WriteLine(String.Join(",", num));
                    num = Task1.GetOnlySmallValues(num);
                    Console.WriteLine(String.Join(",", num));
                    break;

                case "2":
                    Console.Write("Ievadi paroli: ");
                    string password = Console.ReadLine();
                    while (Task2.PasswordValidate(password) == false)
                    {
                        Console.WriteLine("Parole nav derīga, tai jābūt vismaz no 8 simboliem un tai jāsatur gan burti, gan skaitļi");
                        password = Console.ReadLine();
                    }          
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }
    }
}
