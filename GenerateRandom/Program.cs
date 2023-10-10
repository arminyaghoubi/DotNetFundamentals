namespace GenerateRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine(random.Next());//Returns a positive random integer within the default range -2,147,483,648 to 2,147,483, 647.

            Console.WriteLine(random.Next(10));//Returns a positive random integer that is less than the specified maximum value.

            Console.WriteLine(random.Next(1, 7));//Returns a positive random integer within the specified minimum and maximum range (includes min and excludes max).

            Console.WriteLine(random.NextDouble());//Generates random floating-point number that is greater than or equal to 0.0 and less than 1.0.

            byte[] buffer = new byte[10];
            random.NextBytes(buffer);//Fills the specified array with the random bytes.
            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }

            //Seed Value
            Random random1=new Random(5);
            Console.WriteLine(random1.Next());

            Random random2 = new Random(5);
            Console.WriteLine(random2.Next());

            Console.ReadKey();
        }
    }
}