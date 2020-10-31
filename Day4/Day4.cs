using System;

namespace Day4
{
    class Day4
    {
        static void Task4_1()
        {
            string[] names = { "Ilze", "Līva", "Rūta" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("--------------------");
        }

        static void Task4_2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };
            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("--------------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
            Console.WriteLine("--------------------");
        }

        static void Task4_3()
        {
            string[] names = { "Jānis", "Juris", "Līva", "Ilze", "Rūta" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("--------------------");

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Substring(0).Contains('J'))
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.WriteLine("--------------------");

        }

        static void Task4_4()
        {
            //Definēt int tipa masīvu, kurā būs 10 elementi.
            //Izveidot for ciklu, kurš aizpildīs šo masīvu ar skaitļiem.
            //Masīvā ir jāieraksta for cikla mainīgā vērtība.

            int[] arr = new int[10];

            for ( int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            Console.WriteLine(String.Join(",", arr));
            Console.WriteLine("--------------------");

        }

        static void Task4_5()
        {
            //Ar cikla palīdzību izvadīt izvadīt teikumu pretējā virzienā.

            Console.WriteLine("Ievadi kādu frāzi");
            string a = Console.ReadLine();

            for (int i = a.Length-1; i>=0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":
                    Task4_1();
                    break;

                case "2":
                    Task4_2();
                    break;

                case "3":
                    Task4_3();
                    break;

                case "4":
                    Task4_4();
                    break;

                case "5":
                    Task4_5();
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }
        }
    }
}
