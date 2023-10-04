namespace ThrowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                AgeChacker(age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void AgeChacker(int age)
        {
            if (age < 1)
            {
                throw new Exception("Age cannot be less than zero");
            }
        }
    }
}