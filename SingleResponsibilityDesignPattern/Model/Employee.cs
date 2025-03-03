namespace SRP;


#region EmployeeDetails
public class Employee
{
    public Employee(int id, string firstName, string department, long salary)
    {
        EmployeeId = id;
        FirstName = firstName;
        Department = department;
        Salary = salary;
    }
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string Department { get; set; }
    public long Salary { get; set; }
}
#endregion
