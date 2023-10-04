namespace ParameterArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintEvenNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.ReadKey();
        }

        static void PrintEvenNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}