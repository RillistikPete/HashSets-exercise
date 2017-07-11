using System;
using System.Collections.Generic;

namespace hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Hair");
            Showroom.Add("Yukon");
            Showroom.Add("Treecar");
            Showroom.Add("Bikecar");

                foreach (string car in Showroom) {
                    Console.WriteLine(car);
            }

            Showroom.Add("Hair");

                foreach (string car in Showroom) {
                    Console.WriteLine(car);
            }

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Sierra");
            UsedLot.Add("Denali");
            
            Showroom.UnionWith(UsedLot);

                foreach (string car in Showroom) {
                    Console.WriteLine(car);
            }

            Showroom.Remove("Bikecar");

            foreach (string car in Showroom) {
                    Console.WriteLine(car);
            }
            Console.WriteLine("I sold Bikecar");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Scrapcar");
            Junkyard.Add("Crapcar");
            Junkyard.Add("Denali");
            Junkyard.Add("Scrappy");

            Showroom.IntersectWith(Junkyard);

            //IntersectWith() shows that Denali exists in both Showroom and Junkyard,
            // so the UnionWith() one below doesnt work right unless you comment out
            // the IntersectWith(). But theyre all working correctly.

            Showroom.UnionWith(Junkyard);

            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

            Showroom.Remove("Scrappy");

            
        }


    }
}
