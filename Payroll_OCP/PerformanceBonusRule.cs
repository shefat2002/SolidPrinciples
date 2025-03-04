namespace Payroll_OCP
{
    internal class PerformanceBonusRule : IPayroleRull
    {
        public decimal BounsPercentage { get; set; } = 0.15m;
        public decimal Apply(Employee employee, decimal salary)
        {
            return salary + (salary * BounsPercentage);
        }
    }
}
