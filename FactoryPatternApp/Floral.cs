using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace FactoryPatternApp
{
    public class Floral : IFragrance
    {
        public string Name { get; set; } = "Nude Garden";
        public double price { get; set; } = 150.00;
        public string baseNotes { get; set; } = "Gardenia, Rose and Violet";

        public void FragranceStatement()
        {
            Console.WriteLine($"You have an aroma of a garden of flowers! Our collection is called {Name} with the base notes of {baseNotes}. For only {price} dollars"); 
        }
    }
}
