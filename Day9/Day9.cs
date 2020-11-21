using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9
{
    class Day9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi uzdevuma nr.");
            string inp = Console.ReadLine();
            Console.WriteLine("--------------------");

            switch (inp)
            {
                case "1":
                    List<Car> carList = new List<Car>();

                    Car subaru = new Car("Subaru", "Forester", 1500, "silver", 1999);
                    carList.Add(subaru);
                    Car black = new Car("veryBlack", "Custom", 1000000, "black", 2020);
                    carList.Add(black);
                    Car citroen = new Car("Citroen", "Cactus", 20000, "white", 2020);
                    carList.Add(citroen);
                    Car oldAndSmall = new Car("French", "Unknown", 100, "skyBlue", 1980);
                    carList.Add(oldAndSmall);
                    Car shinyNew = new Car("Red", "RedCar", 50000, "red", 2020);
                    carList.Add(shinyNew);

                    Car mostExpensive = new Car();
                    foreach (Car car in carList)
                    {
                        if (car.Price > mostExpensive.Price)
                        {
                            mostExpensive = car;
                        }
                    }

                    Console.WriteLine(mostExpensive.CarDataText());
                    break;

                case "2":
                    
                    List<Ingredient> SastavdalasList = new List<Ingredient>();
                    List<Receipe> RecepteList = new List<Receipe>();
                    
                    //recepte
                    Receipe udens = new Receipe("ūdens", "1 l");              
                    Receipe saals = new Receipe("sāls", "1 ēdamkarote");                
                    Receipe makaroni = new Receipe("makaroni", "0.3 kg");

                    //sasatavdalas
                    Ingredient udens1 = new Ingredient("ūdens", "1 l");
                    Ingredient saals1 = new Ingredient("sāls", "1 ēdamkarote");
                    Ingredient makaroni1 = new Ingredient("makaroni", "0.3 kg");

                    SastavdalasList.Add(udens1);
                    SastavdalasList.Add(saals1);
                    SastavdalasList.Add(makaroni1);

                    RecepteList.Add(udens);
                    RecepteList.Add(saals);
                    RecepteList.Add(makaroni);

                    Receipe.Make();
                    break;

                case "3":                    
                    Chair Chair1 = new Chair();
                    Chair1.Color = "red";
                    Chair1.Dimension = 50;
                    Chair1.Use = "kitchen";

                    Chair Chair2 = new Chair();
                    Chair2.Color = "brown";
                    Chair2.Dimension = 35;
                    Chair2.Use = "living room";

                    Chair Chair3 = new Chair();
                    Chair3.Color = "blue";
                    Chair3.Dimension = 45;
                    Chair3.Use = "school";

                    var chairList = new List<Chair>();

                    chairList.Add(Chair1);
                    chairList.Add(Chair2);
                    chairList.Add(Chair3);

                    Chair blueChair = chairList.Where(x => x.Color.Equals("blue")).First();
                    Console.WriteLine($"{blueChair.Color}, {blueChair.Dimension}, {blueChair.Use}");
                    break;

                case "4":
                    ToDo nr1 = new ToDo();
                    nr1.Name = "RCS majasdarbs";
                    nr1.Description = "C#";
                    nr1.WeekDay = WeekDayEnum.Monday;
                    nr1.MarkAsDone(true);

                    //vai tā, bet tad MarkAsDone nav vienīgā metode, kas var samainīt 
                    /*ToDo nr2 = new ToDo("RCS majasdarbs", "web task", WeekDayEnum.Tuesday, false);             
                    ToDo nr3 = new ToDo("samaksāt rēķinu", "par dzīvokli", WeekDayEnum.Sunday, true);*/

                    ToDo nr2 = new ToDo();
                    nr2.Name = "RCS majasdarbs";
                    nr2.Description = "web task";
                    nr2.WeekDay = WeekDayEnum.Tuesday;
                    nr2.MarkAsDone(false);

                    ToDo nr3 = new ToDo();
                    nr3.Name = "samaksāt rēķinu";
                    nr3.Description = "par dzīvokli";
                    nr3.WeekDay = WeekDayEnum.Sunday;
                    nr3.MarkAsDone(true);
                                    

                    List<ToDo> darbuSaraksts = new List<ToDo>();
                    darbuSaraksts.Add(nr1);
                    darbuSaraksts.Add(nr2);
                    darbuSaraksts.Add(nr3);

                    Console.WriteLine("Darbu saraksts:");
                    foreach (ToDo darbs in darbuSaraksts)
                    {
                        Console.WriteLine(darbs.PrintData());
                    }

                    Console.WriteLine();
                    Console.WriteLine("Darbi, kas nav padarīti:");
                    List<ToDo> navPadariti = darbuSaraksts.Where(darbs => darbs.Done == false).ToList();
                    foreach (ToDo darbs in navPadariti)
                    {
                        Console.WriteLine(darbs.PrintData());
                    }

                    Console.WriteLine();
                    Console.WriteLine("Darbi, kas jāpadara pirmdien:");
                    List<ToDo> toDoMonday = darbuSaraksts.Where(darbs => darbs.WeekDay == WeekDayEnum.Monday).ToList();
                    foreach (ToDo darbs in toDoMonday)
                    {
                        Console.WriteLine(darbs.PrintData());
                    }

                    break;

                case "5":
                    Console.WriteLine("Uzdevums risināts kopā ar uzdevumu nr.4");

                    break;
                case "6":
                    KitchenTable whiteTable = new KitchenTable();
                    whiteTable.Height = 75;
                    whiteTable.Lenght = 140;
                    whiteTable.Widht = 80;
                    whiteTable.Material = "wood";
                    whiteTable.Color = "white";
                    whiteTable.NumOfPersons = 4;

                    KitchenTable smallTable = new KitchenTable();
                    smallTable.Height = 75;
                    smallTable.Lenght = 70;
                    smallTable.Widht = 70;
                    smallTable.Material = "plastic";
                    smallTable.Color = "red";
                    smallTable.NumOfPersons = 2;

                    StudyTable newTable = new StudyTable();
                    newTable.Height = 75;
                    newTable.Lenght = 150;
                    newTable.Widht = 75;
                    newTable.Material = "wood";
                    newTable.Color = "brown";
                    newTable.CableBox = true;

                    List<Table>TableList = new List<Table>();
                    TableList.Add(newTable);
                    TableList.Add(whiteTable);
                    TableList.Add(smallTable);

                    List<Table> WhiteTables = TableList.Where(item => item.Color.Equals("white")).ToList();
                    //te namāku izvadīt pilnus mantoto klašu datus, jo Table klasē neparādās visi dati. String.Join nestrādā.
                    //metodi varētu rakstīt mantotā klasē, bet list var saturēt datus no vairākam mantotām klasēm.
                    foreach (Table x in WhiteTables)
                    {
                        Console.WriteLine(x.PrintTable());
                    }
                    
                    List<Table> Widht75Tables = TableList.Where(item => item.Widht == 75).ToList();
                    /*Console.WriteLine(string.Join(",", Widht75Tables.ToArray()));*/
                    foreach (Table x in Widht75Tables)
                    {
                        Console.WriteLine(x.PrintTable());
                    }


                    break;
                case "7":
                    Client num1 = new Client();
                    num1.name = "Janis";
                    num1.id = 935;
                    num1.balance = 50;

                    Client num2 = new Client();
                    num2.name = "Ilze";
                    num2.id = 950;
                    num2.balance = 150;

                    List<Client> ClientsList = new List<Client>();
                    ClientsList.Add(num1);
                    ClientsList.Add(num2);

                    Console.Write("Ievadi savu ID: ");
                    Console.WriteLine();
                    int ID = Convert.ToInt32(Console.ReadLine());                    

                    Client ATM_Client = ClientsList.Where(x => x.id == ID).FirstOrDefault();

                    if (ATM_Client == null)
                    {
                        Console.WriteLine("Klients nav atpazīts.");
                        return;                                               
                    }
                   
                    Console.Write("Izmaksa: ievadi summu: ");
                    Console.WriteLine();
                    int Cash = Convert.ToInt32(Console.ReadLine());
                    while (Cash <= 0)
                    {
                        Console.Write("Izmaksa: ievadi summu: ");
                        Console.WriteLine();
                        Cash = Convert.ToInt32(Console.ReadLine());
                    }

                    // vēl vajadzētu iestatīt ATM naudas daudzumu un pārbaudīt ar if vai pietiek.

                    if (ATM_Client.balance >= Cash)
                    {
                        Console.WriteLine("Skaita naudu...");
                    }
                    else
                    {
                        Console.WriteLine("Kontā nepietiek līdzekļu!");
                    }
                    break;

                 default:
                    Console.WriteLine("Nr. neatbilst uzdevumu skaitam.");
                    break;
            }        




        }
    }
}
