using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

namespace Day5
{
    class Day5
    {
        static void Task5_1()
        {
            int[] array = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };
            //drukā vērtības, kamēr sastop vērtību 22, tad pārtrauc ciklu.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(22))
                {
                    return;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("--------------------");
        }

        static void Task5_2()
        {
            //apvienot jaunā masīvā vārdus un uzvārdus no atsevišķiem masīviem.
            string[] name = {"Kārlis", "Andris", "Pēteris", "Miķelis", "Jēkabs",
                                        "Mārtiņš", "Teodors", "Alfrēds", "Antons", "Ralfs" };
            string[] surname = {"Liepiņš", "Lapiņš", "Kārkliņš", "Bērziņš", "Kļaviņš",
                                "Ozoliņš", "Egle", "Kociņš", "Kažociņš", "Zariņš" };
            string[] nameSurname = new string[10];

            for (int i=0; i<nameSurname.Length; i++)
            {
                nameSurname[i] = name[i] + " " + surname[i];
                Console.WriteLine(nameSurname[i]);
            }
            Console.WriteLine("--------------------");
        }

        static void Task5_3()
        {
            //jāatrod visas vērtības, kas lielākas 15 un jāievieto jaunā masīvā.
            int[] arr = { 4, 68, 7, 12, 56, 33, 1, 90, 4 };
            List<int> numList = new List<int> ();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 15)
                {
                    numList.Add(arr[i]);
                }
            }
            
            Console.WriteLine(String.Join(",", arr));
            Console.WriteLine(String.Join(",", numList.ToArray()));
            Console.WriteLine("--------------------");

        }

        static void Task5_4()
        {
            //Izdrukāt uz ekrāna tikai tos vārdus, kuros ir atrodams burts “a” vai “ā”.
            string[] names = { "jānis", "pēteris", "andris", "sergejs", "antons" };
            for (int i = 0; i<names.Length; i++)
            {
                if (names[i].Contains('a') || names[i].Contains('ā'))
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.WriteLine("--------------------");
        }

        static void Task5_5()
        {
            //Izdrukāt skaitļus console logā sadalot tos trijās grupās. Skaitļi robežās no 0-30, 31-60, 61-90
            int[] arr = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };

            for (int i=0; i<arr.Length; i++)
            {
                if ( arr[i]>0 && arr[i]<=30)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30 && arr[i] <= 60)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 60 && arr[i] <= 90)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine("--------------------");
        }


        static void Task5_6()
        {
            //Izveidot divdimensiju masīvu int[5,5] un piešķirt elementiem vērtības.
            //Izdrukāt visu elementu vērtības console.


            int[,] arr2d = { { 1, 2, 3, 4, 5 }, { 11, 12, 13, 14, 15 } };

            for (int r=0; r < arr2d.GetLength(0); r++)
            {
                for (int k=0; k < arr2d.GetLength(1); k++)
                {
                    //Console.WriteLine($"[{ r }, { k }] = { arr2d[r , k] }");
                    Console.WriteLine(arr2d[r , k]);
                }
            }
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
                    Task5_1();
                    break;

                case "2":
                    Task5_2();
                    break;

                case "3":
                    Task5_3();
                    break;

                case "4":
                    Task5_4();
                    break;

                case "5":
                    Task5_5();
                    break;

                case "6":
                    Task5_6();
                    break;

                default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }

        }

    }
}








    
