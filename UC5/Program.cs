using System;
namespace UC5
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHrs = 20;
        public const int workingDays = 2;
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            for(int day=0; day<workingDays; day++)
            {
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
                empWage = empHrs * empRatePerHrs;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage:{0}", empWage);
            }
            Console.WriteLine("Total Emp Wage: {0}", totalEmpWage);
        }
    }
}