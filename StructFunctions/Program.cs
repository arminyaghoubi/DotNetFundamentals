namespace StructFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Armin", "Yaghoubi");
            employee1.Salary = 2000;
            employee1.Tax = 20;

            Console.WriteLine(employee1.GetFullName());
            Console.WriteLine("Income: " + employee1.Income());

            Console.ReadKey();
        }
    }

    struct Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName;
        public string LastName;

        public int Salary;
        public int Tax;

        public int Income()
        {
            return ((100 - Tax) * Salary) / 100;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}