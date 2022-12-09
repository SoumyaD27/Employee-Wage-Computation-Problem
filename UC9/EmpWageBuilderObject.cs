using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC9
{
    public class EmpWageBuilderObject
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHrs,int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while(totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHrs;
            Console.Write("Total Emp Wage for company : " + company + "is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + "is: " + this.totalEmpWage;
        }
    }
}
