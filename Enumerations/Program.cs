namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a season for show weather information[Spring=0,Summer=1,Autumn=2,Winter=3]: ");
            int seasonNumber = Convert.ToInt32(Console.ReadLine());

            Season season = (Season)seasonNumber;
            string weatherInformation = season switch
            {
                Season.Spring=> "Averages in whole country are between 20 and 24 °C",
                Season.Summer=> "Averages in whole country are between 27 and 40 °C",
                Season.Autumn=> "Averages in whole country are between 10 and 22 °C",
                Season.Winter=> "Averages in whole country are between 0 and 10 °C"
            };

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