using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageMultipleCompanies
    {
        const int PRESENT_FULL_TIME = 1;
        const int PRESENT_PART_TIME = 2;

        public int CalculateMonthlyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Random random = new Random();

            int totalEmpWage;
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalWorkingDays < numOfWorkingDays && totalEmpHrs <= maxHoursPerMonth)
            {
                totalWorkingDays++;
                int check = random.Next(0, 3);

                switch (check)
                {
                    case PRESENT_FULL_TIME:
                        Console.WriteLine("Employee Present: Full Time");
                        empHrs = 8;
                        break;
                    case PRESENT_PART_TIME:
                        Console.WriteLine("Employee Present: Part Time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee Absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);

            return totalEmpWage;
        }
    }
}
