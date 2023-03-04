using HarshaCompany.Domain.Employees;

Employee.OrganizationName = "Harsha Inc.";

var employees = new List<Employee>();

Console.WriteLine($"Welcome to {Employee.OrganizationName}");

for (var i = 0; i < 10; i++)
{
    AddNewEmployee(employees);
    Console.WriteLine(employees[i].GetEmployeeInformation());

    if (i == 9)
    {
        Console.WriteLine($"\nIt was the last empty place in {Employee.OrganizationName}.");
        break;
    }

    Console.WriteLine("\nTo add more write 'y' to continue or any other key to stop.");

    if (Console.ReadLine() != "y")
    {
        break;
    }
}

Console.WriteLine("See you again!");

static void AddNewEmployee(List<Employee> employeesList)
{
    Console.WriteLine("\nTo add a new employee You should write some information first.\nWrite id of the new employee.");

    var newEmployee = new Employee("Finance Department");

    while (true)
    {
        var input = Console.ReadLine();

        if (int.TryParse(input, out _))
        {
            newEmployee.EmpId = int.Parse(input);
            break;
        }

        Console.WriteLine("Id shod be integer. Try again.");
    }

    Console.WriteLine("Write the name.");

    while (true)
    {
        var input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            newEmployee.EmpName = input;
            break;
        }

        Console.WriteLine("Name can not be empty! Try again.");
    }

    Console.WriteLine($"Write {newEmployee.EmpName}`s salary per hour.");

    while (true)
    {
        var input = Console.ReadLine();

        if (double.TryParse(input, out _))
        {
            var salaryPerHour = double.Parse(input);

            if (salaryPerHour > 0)
            {
                newEmployee.SalaryPerHour = salaryPerHour;
                break;
            }
        }

        Console.WriteLine("Salary per hour should be a number and more that 0. Try again.");
    }

    Console.WriteLine($"Write {newEmployee.EmpName}`s worked hours.");

    while (true)
    {
        var input = Console.ReadLine();

        if (double.TryParse(input, out _))
        {
            var noOfWorkingHours = double.Parse(input);

            if (noOfWorkingHours > 0)
            {
                newEmployee.NoOfWorkingHours = noOfWorkingHours;
                break;
            }
        }

        Console.WriteLine("Worked hours should be a number and more that 0. Try again.");
    }

    employeesList.Add(newEmployee);
    Console.WriteLine($"Thanks! {newEmployee.EmpName} has been added to {Employee.OrganizationName}");
}