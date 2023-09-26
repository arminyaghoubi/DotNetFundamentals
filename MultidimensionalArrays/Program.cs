namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2,3] { { 10, 20, 30 }, { 15, 10, 60 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"|{numbers[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}