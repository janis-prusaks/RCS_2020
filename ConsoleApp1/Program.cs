using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reizrēķina tabulai ievadi pozitīvu skaitli, ne lielāku par 20");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            while (x < 0 || x > 20)
            {
                Console.WriteLine("Nekorekts skaitlis. Ievadi pozitīvu skaitli, ne lielāku par 20");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------");

            }
            int a = 1;
            int b = 1;
                       
           
            while (a <= x)
            {
                while (b <= x)
                {
                    Console.Write(a * b + " ");
                    b++;
                }

                Console.WriteLine(" ");

                b = 1;
                a = a + 1;

            }
            
            
            

            




        }
    }
}
