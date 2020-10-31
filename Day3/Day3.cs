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
            //Deklarēt programmā bool tipa mainīgo, kura sākotnējā vērtība ir TRUE.
            //Izveidot while ciklu, kurš atkārtojas tik ilgi, kamēr mainīgā vērtība ir TRUE.
            //Mainīgā vērtību uz FALSE ir jānomaina, tad, kad cikls ir atkārtojies 20 reizes.

            bool a = true;
            Console.WriteLine(a);
            int i = 0;
            while (i < 20)
            {
                i++;
                Console.WriteLine(i);

            }
            a = false;
            Console.WriteLine(a);
        }

        static void Task3_4()
        {
            Console.WriteLine("Cik reizes vēlies atkārtot `Hello world`?");
            int x = Convert.ToInt32(Console.ReadLine());

            for ( int i = 1; i <= x ; i++ )
            {
                Console.WriteLine("Hello world!");
            }
        }

        static void Task3_5()
        {
            //Izdrukāt uz ekrāna pirmā un pēdējā elementa vērtības.

            int[] array = { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine(array[0]);
            Console.WriteLine(array[array.Length-1]);
        }

        static void Task3_6()
        {
            //Samainīt elementu, kura sākotnējā vērtība ir 3 uz 10.

            int[] array = { 7, 4, 7, 3, 6, 9, 2 };            
            Console.WriteLine(String.Join(",", array));
            for ( int i=0; i<array.Length; i++)
            {
                if (array[i].Equals(3))
                {
                    array[i] = 10;
                }
            }
                     
            Console.WriteLine(String.Join(",", array));
        }

        static void Task3_7()
        {
            string[] names = { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(names[1]);
            names[2] = "Jēkabs";
            Console.WriteLine(String.Join(",", names));
            
        }

        enum WeekDays 
        {
            pirmdiena,
            otrdiena,
            trešdiena,
            ceturtdiena,
            piektdiena,
            sestdiena,
            svētdiena
        }


        static void Task3_8()
        {
            var a = (WeekDays) 4;
            Console.WriteLine(a);
            
        }

            


      

        static void Task3_9()
        {
            // nav pabeigts


            Console.WriteLine("Reizrēķina tabulai ievadi pozitīvu skaitli, ne lielāku par 20");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            while ( x < 0 || x > 20)
            {
                Console.WriteLine("Nekorekts skaitlis. Ievadi pozitīvu skaitli, ne lielāku par 20");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------");

            }
            int a = 1;
            int b = 1;
            while ( a < x)
            {
                             
                while ( b <= x )
                {
                    Console.Write(a * b + "  ");
                    b ++;
                }

                Console.WriteLine(" ");
                ++ a;
                Console.Write(a);
            
            }

            


        }    
        

       





        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

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

                case "5":
                    Task3_5();
                    break;
                case "6":
                    Task3_6();
                    break;
                case "7":
                    Task3_7();
                    break;
                case "8":
                    Task3_8();
                    break;
                case "9":
                    Task3_9();
                    break;
            default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;

            }
        }
    }
}
