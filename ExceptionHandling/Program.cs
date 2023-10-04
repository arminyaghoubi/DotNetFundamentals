namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 0;

            DivisionResult result = Division(number1, number2);

            if (!result.HasError)
            {
                Console.WriteLine($"{number1} / {number2} = {result.Value}");
            }

            Console.ReadKey();
        }

        static DivisionResult Division(int number1, int number2)
        {
            DivisionResult result = new DivisionResult();
            try
            {
                result.Value = number1 / number2;
                return result;
            }
            catch
            {
                Console.WriteLine("The second number cannot be zero");
                result.HasError = true;
                return result;
            }
        }
    }

    struct DivisionResult
    {
        public int Value;
        public bool HasError;

        public DivisionResult()
        {
            HasError = false;
        }
    }
}