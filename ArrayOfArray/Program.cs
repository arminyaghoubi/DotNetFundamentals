namespace ArrayOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] playerScores = new int[2][]
            {
                new int[] { 50, 70,60},
                new int[] { 20, 30,40},
            };


            for (int i = 0; i < playerScores.Length; i++)
            {
                Console.WriteLine($"Score list player {i + 1}");
                foreach (var score in playerScores[i])
                {
                    Console.WriteLine($"\t{score}");
                }
                Console.WriteLine("--------------------");
            }

            Console.ReadKey();
        }
    }
}