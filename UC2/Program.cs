using System;
namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int empRatePerHrs = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck==isFullTime)
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