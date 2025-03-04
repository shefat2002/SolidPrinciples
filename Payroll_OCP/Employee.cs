namespace Payroll_OCP
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public abstract decimal CalculateSalary();
    }
}
