using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Parts = new List<string>();
            List<string> newList = new List<string>();

            Parts.Add("Name: Asap");
            Parts.Add("Name: osman");
            Parts.Add("Name: abass");
            Parts.Add("Name: innorik");
            Parts.Add("Name: pat");
            Parts.Add("Name: mat");
            Parts.Add("Name: jes");
            Parts.Add("Name: jos");

            foreach (var part in Parts)
            {
                Console.WriteLine(part);

                newList.Add(part);
                newList.Sort();
               

            };

            foreach (var lis in newList)
            {
                Console.WriteLine($"{"new List: "+lis}");
                }
                   
        }
  }

   
}

 
