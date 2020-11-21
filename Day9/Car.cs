using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Day9
{
    class Car
    {
        public string Make;
        public string Model;
        public float Price;
        public string Color;
        public int Year;

        public Car(string make, string model, float price, string color, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Year = year;
        }

        public Car()
        {
            string Make;
            string Model;
            float Price;
            string Color;
            int Year;
            
        }
        


        public string CarDataText()
        {
            return $"{this.Make}, {this.Model}, {this.Price:0.##}, {this.Color}, {this.Year}";
        }

        

    }
}
