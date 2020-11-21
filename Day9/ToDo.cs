using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    enum WeekDayEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
        

    class ToDo
    {       

        public string Name { get; set; }
        public string Description { get; set; }
        public WeekDayEnum WeekDay { get; set; }
        public bool Done { get; set; }



/*        public ToDo(string name, string description, WeekDayEnum day, bool isDone)
        {
            this.Name = name;
            this.Description = description;
            this.WeekDay = day;
            this.Done = isDone;
        }*/

        public ToDo()
        {

        }

        public string PrintData()
        {
            return $"{this.Name}, {this.Description}, {this.WeekDay}, {this.Done}";
        }


       


        public bool MarkAsDone(bool isDone)
        {
            if(isDone == true)
            {
                return this.Done = true;
            }
            return this.Done = false;
                    
        }


    }










}
