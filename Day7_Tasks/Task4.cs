using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day7_Tasks
{
    class Task4
    {
        public static string [] GetNonEmtyArray (string[] array)
        {
            List<string> newArray = new List<string> ();
            array.ToList();
            foreach (string name in array2)
            {
                array2.RemoveAll(item => item.Equals(""));
            }
            return array2.ToArray();         
        }
    }
}
