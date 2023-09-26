namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a season for show weather information[Spring=0,Summer=1,Autumn=2,Winter=3]: ");
            int seasonNumber = Convert.ToInt32(Console.ReadLine());

            Season season = (Season)seasonNumber;
            string? weatherInformation = null;

            switch (season)
            {
                case Season.Spring:
                    weatherInformation = "Averages in whole country are between 20 and 24 °C";
                    break;
                case Season.Summer:
                    weatherInformation = "Averages in whole country are between 27 and 40 °C";
                    break;
                case Season.Autumn:
                    weatherInformation = "Averages in whole country are between 10 and 22 °C";
                    break;
                case Season.Winter:
                    weatherInformation = "Averages in whole country are between 0 and 10 °C";
                    break;
            }

            Console.WriteLine(weatherInformation);

            Console.ReadKey();
        }
    }

    enum Season
    {
        Spring = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 3
    }
}