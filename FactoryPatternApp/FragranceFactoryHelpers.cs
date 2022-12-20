using FactoryPatternApp;

internal static class FragranceFactoryHelpers
{
    public static IFragrance GetFragrance(char typeOfScent)
    {
        switch (typeOfScent)
        {
            case 'g':
                return new Gourmand();
            case 'w':
                return new Floral();

            case 'f':
                return new Fruity();
            default:
                return new Fruity();
        }
    }
}