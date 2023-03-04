namespace HarshaCompany.Domain.Employees;

public class Employee
{
    public int EmpId;
    public string? EmpName;
    public double SalaryPerHour;
    public double NoOfWorkingHours;
    public double NetSalary;
    public static string? OrganizationName;
    public const string TypeOfEmployee = "Contract Based";
    public readonly string DepartmentName;

    public Employee(string departmentName)
    {
        DepartmentName = departmentName;
    }

    public string GetEmployeeInformation()
    {
        NetSalary = SalaryPerHour * NoOfWorkingHours;
        return $"\nEmployee id : {EmpId};\nName : {EmpName};\nSalary per hour : {SalaryPerHour};\nNet of work hours : {NoOfWorkingHours};\nNet salary : {NetSalary};\nOrganization name : {OrganizationName};\nType of employee : {TypeOfEmployee};\nDepartment name : {DepartmentName}";
    }
}