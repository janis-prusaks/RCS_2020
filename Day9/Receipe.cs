using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Receipe
    {
        public string Name { get; set; }
        public string Vol { get; set; }

        public Receipe( string name, string volume)
        {
            this.Name = name;
            this.Vol = volume;
        }

        


        public static void Make()
        {
            List<Ingredient> SastavdalasList = new List<Ingredient>();
            List<Receipe> RecepteList = new List<Receipe>();        


        }
    }
}
