using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
   public interface IFragrance
    {
        public string Name { get; set; }
        public double price { get; set; }
        public  string baseNotes { get; set; }
        public void FragranceStatement();
            
           
    }
}
