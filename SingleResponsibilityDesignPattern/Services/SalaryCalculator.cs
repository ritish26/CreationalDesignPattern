namespace SRP;


#region CalculateSalary
public class SalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.Salary + (employee.Salary * .10);
    }
}
#endregion
