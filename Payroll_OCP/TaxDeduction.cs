namespace Payroll_OCP
{
    internal class TaxDeduction : IPayroleRull
    {
        public decimal TaxRate { get; set; } = 0.15m;
        public decimal Apply(Employee employee, decimal salary)
        {
            return salary - (salary * TaxRate);
        }
    }
}
