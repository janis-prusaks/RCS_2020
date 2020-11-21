using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Ingredient
    {
        public string Name { get; set; }
        public string Vol { get; set; } 
        
        public Ingredient (string name, string volume)
        {
            this.Name = name;
            this.Vol = volume;
        }


    }

}
