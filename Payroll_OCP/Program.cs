using Payroll_OCP;

var employees = new List<Employee>()
{
    new GeneralSalary("Rahim" , 20000),
    new HourlySalary("Jahid" , 200, 48)
};

var payrolls = new List<IPayroleRull>()
{
    new TaxDeduction(),
    new HealthInsurance(),
    new PerformanceBonusRule()
};

var processPayrole = new ProcessPayroll(payrolls);
foreach(var employee in employees)
{
    decimal finalSalary = processPayrole.PayroleProcess(employee);
    Console.WriteLine($"{finalSalary}");
}