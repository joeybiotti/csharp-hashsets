using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>{"Prius", "Volt", "Leaf", "Tesla"};
            Showroom.Add("Prius");
            Console.WriteLine($"The number of cars in the showroom: {Showroom.Count}");

            HashSet<string> UsedLot = new HashSet<string>{"AMC Gremlin", "Model T"};
            Console.WriteLine($"Number of used cars: {UsedLot.Count}");
            
            HashSet<string> TotalCars = new HashSet<string>(Showroom);
            Showroom.UnionWith(UsedLot);
            Console.WriteLine($"Total number of cars, showroom and used lot: {Showroom.Count}");

            Showroom.Remove("Volt");
            Console.WriteLine($"Sold the Chevy Volt, the count is now: {Showroom.Count}");

            HashSet<string> Junkyard = new HashSet<string>{"Pinto", "Dodge Ram", "Leaf", "Taurus", "Tesla", "Model T"};
            Console.WriteLine($"Number of cars in junkyard: {Junkyard.Count}");

            HashSet<string> Duplicates = new HashSet<string>(Showroom);
            Showroom.IntersectWith(Junkyard);
            Console.WriteLine($"Duplicates in junkyard: {Showroom.Count}");

            HashSet<string> BoughtJunkers = new HashSet<string>(Showroom);
            Showroom.UnionWith(Junkyard);
            Console.WriteLine($"Total cars after buying junkyard: {Showroom.Count}");
        }
            
    }
}

