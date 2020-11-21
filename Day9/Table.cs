using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Table
    {
        public int Height { get; set; }
        public int Lenght { get; set; }
        public int Widht { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }


        /*        public Table(int height, int lenght, int widht, string material)
                {
                    this.Height = height;
                    this.Lenght = lenght;
                    this.Widht = widht;
                    this.Material = material;
                }*/

        public string PrintTable()
        {
            return $"{this.Height}, {this.Lenght}, {this.Widht}, {this.Material}, {this.Color}";
        }







    }
}
