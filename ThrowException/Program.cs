namespace ThrowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name="Armin";
                int age = Convert.ToInt32(Console.ReadLine());
                AgeChacker(age,ref name);
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

        static void AgeChacker(int age,ref string name)
        {
            name += " Yaghoubi";
            if (age < 1)
            {
                throw new Exception("Age cannot be less than zero");
            }
        }
    }
}