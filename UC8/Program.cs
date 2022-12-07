class Program
{
    public const int isPartTime = 1;
    public const int isFullTime = 2;
    public static int computeEmpWage(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonths)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= maxHrsPerMonths && totalWorkingDays < numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
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
        Console.WriteLine("Total Emp Wage for comapany: " + company + "is " + totalEmpWage);
        return totalEmpWage;
    }
    static void Main(string[] args)
    {
        computeEmpWage("DMart ", 20, 2, 10);
        computeEmpWage("Reliance ", 10, 4, 20);

    }
}