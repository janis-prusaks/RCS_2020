using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Tasks
{
    class Task6
    {
        public static bool ValidatePersonId (string personald)
        {
            if (personald.Length != 12)
            {
                Console.WriteLine("Nekorekts personas kods");
                personald = Console.ReadLine();
            }

            if (!personald.Substring(6, 1).Equals("-"))
            {
                Console.WriteLine("Nekorekts personas kods");
                personald = Console.ReadLine();
            }

            return true;
        }

        public static void PrintBirthday (string personald)
        {
            string date = personald.Substring(0, 2);
            string month = personald.Substring(2, 2);            
            switch(month)
            {
                case "01":
                    month = "janvāris";
                break;

                case "02":
                    month = "februāris";
                    break;

                case "03":
                    month = "marts";
                    break;

                case "04":
                    month = "aprīlis";
                    break;

                case "05":
                    month = "maijs";
                    break;

                case "06":
                    month = "jūnijs";
                    break;

                case "07":
                    month = "jūlijs";
                    break;

                case "08":
                    month = "augusts";
                    break;

                case "09":
                    month = "septembris";
                    break;

                case "10":
                    month = "oktobris";
                    break;

                case "11":
                    month = "novembris";
                    break;

                case "12":
                    month = "decembris";
                    break;

                default:
                    month = "Nekorekts mēneša skaitlis";
                    break;
            }

            int year = int.Parse(personald.Substring(4, 2));
            if (year > 19)
            {
                year = 1900 + year;
            } 
            else
            {
                year = 2000 + year;
            }
                       
            
            Console.WriteLine($"{year}. gada {date}.{month}");
        }




    }

}
