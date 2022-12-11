using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10EmployeeWageOfMultipleCompanies
{
    public class CompanyEmpWage
    {
        public string company;
        public int numOfWorkingDays;
        public int empRatePerHrs;
        public int maxHrsPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int numOfWorkingDays, int empRatePerHrs, int maxHrsPerMonth)
        {
            this.company = company;
            this.numOfWorkingDays = numOfWorkingDays;
            this.empRatePerHrs = empRatePerHrs;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
