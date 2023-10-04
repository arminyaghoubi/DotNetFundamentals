namespace OverloadingFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber1 = 10;
            int intNumber2 = 20;
            int intResult = Add(intNumber1,intNumber2);
            Console.WriteLine($"{intNumber1} + {intNumber2} = {intResult}");

            float floatNumber1 = 10.5f;
            float floatNumber2 = 20.7f;
            float floatResult = Add(floatNumber1, floatNumber2);
            Console.WriteLine($"{floatNumber1} + {floatNumber2} = {floatResult}");

            Console.ReadKey();
        }

        static int Add(int number1,int number2)
        {
            return number1 + number2;
        }

        static float Add(float number1, float number2)
        {
            return number1 + number2;
        }
    }
}