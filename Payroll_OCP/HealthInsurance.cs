namespace Payroll_OCP
{
    internal class HealthInsurance : IPayroleRull
    {
        public decimal InsuranceFee { get; set; } = 200m;
        public decimal Apply(Employee employee, decimal salary)
        {
            return salary - InsuranceFee;
        }
    }
}
