using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
     public class Fruity : IFragrance
    {
        public string Name { get; set; } = "Fruity Tooty";
        public double price { get; set; } = 150.00;
        public string baseNotes { get; set; } = "Strawberry, Cherries and Chocolate";

        public void FragranceStatement()
        {
            Console.WriteLine($"You have a very sweet and fruity aroma!  this is a special addition to our collection called {Name} and the price of {price}. This addition has the base notes of {baseNotes}");
            
        }
    }
}
