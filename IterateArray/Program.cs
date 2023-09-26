namespace IterateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Armin", "Shayan", "Nikan" };

            // First way
            int counter = 0;
            while (counter < names.Length)
            {
                Console.WriteLine(names[counter]);
                counter++;
            }
            // Second way
            counter = 0;
            do
            {
                Console.WriteLine(names[counter]);
                counter++;
            } while (counter < names.Length);
            // Third way
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Forth way
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}