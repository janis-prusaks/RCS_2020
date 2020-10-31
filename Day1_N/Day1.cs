using System;

namespace Day1_N
{
    class Day1Program
    {

        static void Task01(string text)
        {
            Console.WriteLine(text);

        }

        static void Task02(bool c, string d)
        {
            int a = 1;
            double b = 0.15;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static void Task03(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }

        static void Task04()
        {
            Console.WriteLine("Ievadi savu vārdu");
            string inp = Console.ReadLine();
            Console.WriteLine(inp);

        }

        static void Task05()
        {
            Console.WriteLine("Ievadi savu vārdu un uzvārdu");
            string inp = Console.ReadLine();
            string name = inp.Substring(0, 1).ToUpper();
            string surname = inp.Substring(inp.IndexOf(' '));
            Console.WriteLine(name + "." + surname);
        }

        static void ExtraTask()
        {


        }



        static void Main(string[] args)
        {

            Console.Write("Ievadi uzdevuma nr. :");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":
                    Task01("Jānis Prusaks");
                    break;
                case "2":
                    Task02(true, "jap");
                    break;
                case "3":
                    Task03(10, 15);
                    break;
                case "4":
                    Task04();
                    break;
                case "5":
                    Task05();
                    break;
                case "6":
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam");
                    break;

            }

        }


    }
}
