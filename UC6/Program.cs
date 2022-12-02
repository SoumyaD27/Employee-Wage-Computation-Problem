using System;
namespace UC6
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHrs = 20;
        public const int workingDays = 2;
        public const int maxHrsInMonth = 10;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs<=maxHrsInMonth && totalWorkingDays<workingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);

            }
            int totalEmpWage = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}