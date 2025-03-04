namespace Payroll_OCP
{
    internal class GeneralSalary : Employee
    {
        public GeneralSalary(string name, decimal baseSalary) : base(name, baseSalary)
        {
        }
        public override decimal CalculateSalary()
        {
            return BaseSalary; //????
                
        }
    }
}
