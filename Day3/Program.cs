using System;

namespace Day3
{
    class Day3Program
    {
        static void Task3_1()
        {
            int[] array = { 1, 6, 7, 78, 9, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        static void Task3_2()
        {
            Console.WriteLine("Vai vēlies pusdienas? (TRUE vai FALSE)");
            bool a = Convert.ToBoolean(Console.ReadLine());
            if (a)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else if (!a)
            {
                Console.WriteLine("Jums pusdienas nebūs.");
            }
            else
            {
                Console.WriteLine("Kā lūdzu?");
            }

        }

        static void Task3_3()
        {
            bool a = true;
            int i = 0;
            while (i < 20)
            {
                i++;
                Console.WriteLine(i);

            }
            a = false;
            Console.WriteLine(a);
        }






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
                    /* Task3_3();*/
                    break;

                case "4":
                    /*Task3_4extra();*/
                    break;

                case "5":
                    /*t;*/
                    break;
                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;

            }
        }
    }
}
