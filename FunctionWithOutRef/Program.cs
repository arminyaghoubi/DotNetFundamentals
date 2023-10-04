namespace FunctionWithOutRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            SetInitialValue(out number);
            Console.WriteLine($"Current number is {number}");
            NextNumber(ref number);
            Console.WriteLine($"Current number is {number}");
            Console.ReadKey();
        }

        static void SetInitialValue(out int number)
        {
            number = 10;
        }

        static void NextNumber(ref int number)
        {
            number++;
        }
    }
}