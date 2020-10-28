using System;

namespace Day2
{
    class Day2Program
    {
        static void Task2_1()
        {
        firstInputStart:
            Console.WriteLine("Ievadi skaitli robežās no 0 līdz 20 ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x < 20)
            {
            secondInputStart:
                Console.WriteLine("Ievadi otru skaitli robežās no 30 līdz 50 ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y >= 30 && y < 50)
                {
                    Console.WriteLine(String.Format("Skaitļu {0} un {1} summa ir {2}", x, y, x + y));
                }
                else
                {
                    Console.WriteLine("Kļūda. Skaitlis nav robežās no 30 līdz 50 ");
                    goto secondInputStart;
                }

            }
            else
            {
                Console.WriteLine("Kļūda. Skaitlis nav robežās no 0 līdz 20 ");
                goto firstInputStart;
            }
        }

        static void Task2_2()
        {
            //InputStart:
            Console.WriteLine("Saki priekšmeta nosaukumu un es pateikšu, kur to nolikt.");
            string input = Console.ReadLine();
            string a = input.Substring(0, 1).ToLower();

            if (a.Equals("a") || a.Equals("b") || a.Equals("c") || a.Equals("d"))
            {
                Console.WriteLine("Lūdzu noliec to 1.stāvā!");
            }
            else if (a.Equals("e") || a.Equals("f") || a.Equals("g") || a.Equals("h"))
            {
                Console.WriteLine("Lūdzu noliec to 2.stāvā!");
            }
            else if (a.Equals("i") || a.Equals("j") || a.Equals("k") || a.Equals("l"))
            {
                Console.WriteLine("Lūdzu noliec to 3.stāvā!");
            }
            else if (a.Equals("m") || a.Equals("n") || a.Equals("o") || a.Equals("p"))
            {
                Console.WriteLine("Lūdzu noliec to 4.stāvā!");
            }
            else if (a.Equals("r") || a.Equals("s") || a.Equals("t") || a.Equals("u"))
            {
                Console.WriteLine("Lūdzu noliec to 5.stāvā!");
            }
            else
            {
                Console.WriteLine("Lūdzu noliec to pagrabā!");
            }

            //goto InputStart;

        }

        static void Task2_3(int augstums_cm, int diam_cm, bool sudrabegle)
        {
            if (sudrabegle == true)
            {
                Console.WriteLine("Kamīnzāle");
            }

            else if (50 <= augstums_cm && augstums_cm < 100 && 100 <= diam_cm && diam_cm < 150)
            {
                Console.WriteLine("Viesistaba 1");
            }
            else if (100 <= augstums_cm && augstums_cm < 150 && 150 <= diam_cm && diam_cm < 200)
            {
                Console.WriteLine("Viesistaba 2");
            }
            else if (150 <= augstums_cm && augstums_cm <= 300 && 200 <= diam_cm && diam_cm <= 300)
            {
                Console.WriteLine("Kamīnzāle");
            }
            else
            {
                Console.WriteLine("Hmm...kur tādu likt?");
            }

        }


        static void Task2_4extra()
        {
            Console.WriteLine("Ievadi pirmā spēlētāja vārdu");
            string name1 = Console.ReadLine();

            Console.WriteLine("Ievadi pirmā spēlētāja punktu skaitu");
            Console.Write("1: ");
            int n1_1 = int.Parse(Console.ReadLine());
            Console.Write("2: ");
            int n1_2 = int.Parse(Console.ReadLine());
            Console.Write("3: ");
            int n1_3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi otrā spēlētāja vārdu");
            string name2 = Console.ReadLine();
            Console.WriteLine("Ievadi otrā spēlētāja punktu skaitu");
            Console.Write("1: ");
            int n2_1 = int.Parse(Console.ReadLine());
            Console.Write("2: ");
            int n2_2 = int.Parse(Console.ReadLine());
            Console.Write("3: ");
            int n2_3 = int.Parse(Console.ReadLine());

            if ((n1_1 + n1_2 + n1_3) > (n2_1 + n2_2 + n2_3))
            {
                Console.WriteLine("Uzvarētājs ir " + name1);
            }
            else if ((n1_1 + n1_2 + n1_3) < (n2_1 + n2_2 + n2_3))
            {
                Console.WriteLine("Uzvarētājs ir " + name2);
            }
            else
            {
                Console.WriteLine("Neizšķirts!");
            }


        }



        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();

            switch (inp)
            {
                case "1":
                    Task2_1();
                    break;

                case "2":
                    Task2_2();
                    break;

                case "3":
                    Task2_3(150, 100, false);
                    break;

                case "4":
                    Task2_4extra();
                    break;
                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam");
                    break;

            }



        }
    }
}
