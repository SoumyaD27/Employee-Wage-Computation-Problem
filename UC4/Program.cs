using System;
namespace UC4
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHrs = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
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
            Console.WriteLine("Emp Wage: {0}", empWage);
        }
    }
}