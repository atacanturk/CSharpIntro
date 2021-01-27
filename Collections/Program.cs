using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            List<string> names1 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            names1.Add("İlker"); // the difference between array and list
            Console.WriteLine(names1[4]);
            Console.WriteLine(names1[0]);
 
        }
    }
}
