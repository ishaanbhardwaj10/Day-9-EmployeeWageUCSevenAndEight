namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Use Case #8: Employee Wage for Multiple Companies");
            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 8:
                    EmployeeWageMultipleCompanies employeeWageMultipleCompanies = new EmployeeWageMultipleCompanies();
                    employeeWageMultipleCompanies.CalculateMonthlyWage("Flipkart", 20, 10, 60);
                    employeeWageMultipleCompanies.CalculateMonthlyWage("Amazon", 20, 15, 80);
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
        }
    }
}