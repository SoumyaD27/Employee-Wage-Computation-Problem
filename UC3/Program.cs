using System;
namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empRatePerHrs = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==isPartTime)
            {
                empHrs = 4;
            }
            else if(empCheck==isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHrs;
            Console.WriteLine("Emp Wage: {0}", empWage);
        }
    }
}