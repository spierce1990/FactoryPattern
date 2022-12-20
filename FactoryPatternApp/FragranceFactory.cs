using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public static class FragranceFactory
    {
        public static IFragrance GetFragrance(string typeOfScent)
        {
            switch (typeOfScent.ToLower())
        {
            case "gourmand":

                    return new Gourmand();
            case "floral":
                    return new Floral();

            case "fruity":
                    return new Fruity();
            default:
                    return new Fruity();
        }
        }
    }
}
