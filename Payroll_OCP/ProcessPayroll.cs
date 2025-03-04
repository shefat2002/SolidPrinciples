namespace Payroll_OCP
{
    internal class ProcessPayroll
    {
        private readonly List<IPayroleRull> _payroleRules;
        public ProcessPayroll(List<IPayroleRull> payroleRules)
        {
            _payroleRules = payroleRules;
        }
        public decimal PayroleProcess(Employee employee)
        {
            decimal salary = employee.CalculateSalary();
            foreach(var rule in _payroleRules)
            {
                salary = rule.Apply(employee, salary);
            }
            return salary;
        }
    }
}
