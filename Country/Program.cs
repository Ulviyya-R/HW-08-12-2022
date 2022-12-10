namespace Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkiye");
            Country country = new Country("Turkiye",85000000);
            country.cities.Add(new City("Istanbul", 16000000));
            country.cities.Add(new City("Izmir", 4400000));
            country.cities.Add(new City("Bodrum", 181000));
            country.cities.Add(new City("Antalya", 870000));
            country.cities.Add(new City("SanliUrfa", 590000));
            country.FindAllByPopulation(0,5);

            Console.WriteLine("France");
            Country country1 = new Country("France", 68000000);
            country1.cities.Add(new City("Paris", 2200000));
            country1.cities.Add(new City("Toulouse", 440000));
            country1.cities.Add(new City("Marseille", 1600000));
            country1.cities.Add(new City("Nice", 340000));
            country1.cities.Add(new City("Montpellier", 260000));
            country1.FindAllByPopulation(0, 4);

        }

    }
}