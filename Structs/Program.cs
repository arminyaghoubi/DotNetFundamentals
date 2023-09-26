namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string? firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string? lastName = Console.ReadLine();

            Student student = new Student(firstName,lastName);

            Console.WriteLine(student);

            Console.ReadKey();
        }
    }

    struct Student
    {
        public Student(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Full Name: {FirstName} {LastName}";
        }
    }
}