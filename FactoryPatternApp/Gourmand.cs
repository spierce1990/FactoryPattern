using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public class Gourmand : IFragrance
    {
        public string Name { get; set; } = "Edible Me";
        public double price { get; set; } = 170.25;
        public string baseNotes { get; set; } = "Vanilla, tonka bean and musk";

        public void FragranceStatement()
        {
            Console.WriteLine($"You have an aroma of vanilla and edible sugar! The base notes are {baseNotes}, This collection is called {Name}, with the price of {price}"); 
        }
    }
}
