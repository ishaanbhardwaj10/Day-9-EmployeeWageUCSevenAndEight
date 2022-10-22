using System;

namespace DayEightEmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_A_MONTH = 100;

        public static int ComputeEmployeeWage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random random = new Random();
            int empWage = 0, empHrs = 0, totalEmpWage = 0, totalWorkingHrs = 0, day = 0;

            while (totalWorkingHrs <= MAX_HRS_IN_A_MONTH && day < NUMBER_OF_WORKING_DAYS)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Daily employee wage: " + empWage);
                totalWorkingHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total working hours in the month: {0}", totalWorkingHrs);
            Console.WriteLine("Total number of working days: {0}", day);
            Console.WriteLine("Total employee wage for the month is: {0}", totalEmpWage);
            return totalEmpWage;
        }

        public static void Main(string[] args)
        {
            ComputeEmployeeWage();
        }
    }
}