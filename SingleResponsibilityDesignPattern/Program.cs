// See https://aka.ms/new-console-template for more information
namespace SRP;

/// Problem Statement :
/// Imagine you are designing an Employee Management System. This system needs to handle multiple responsibilities,
/// such as storing employee details, calculating salaries, and sending payroll notifications to employees.

#region MainExecutionRegion
public static class SingleResponsibilityPrinciple
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1,"John","Doe",27000);
        
        SalaryCalculator calc = new SalaryCalculator();
        var totalSalary = calc.CalculateSalary(emp);
        Console.WriteLine($"Salary of Employee {emp.FirstName} is {totalSalary}");
        
        NotificationService service = new NotificationService();
        service.SendNotification(emp.FirstName);
    }
}
#endregion
