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
            List<string> list = new List<string>();
            foreach (string item in array)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    list.Add(item);
                }
            }
            return list.ToArray();

            //return array.Where(item => !String.IsNullOrEmpty(item).ToArray();
            
        }
    }
}
