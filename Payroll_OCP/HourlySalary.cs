namespace Payroll_OCP
{
    internal class HourlySalary:Employee
    {
        public decimal RatePerHour { get; set; }
        public decimal WorkingHours { get; set; }
        public HourlySalary(string name, decimal ratePerHour, decimal workingHours): base(name, 0) //??
        {
            RatePerHour = ratePerHour;
            WorkingHours = workingHours;
        }
        public override decimal CalculateSalary()
        {
            return WorkingHours * RatePerHour;
        }
    }
}
