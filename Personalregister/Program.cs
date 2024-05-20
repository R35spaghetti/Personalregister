using Personalregister.Models;


Console.WriteLine("Enter employee's name");
string employeeNameInput = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Enter employee's salary");
string employeeSalaryInput = Console.ReadLine() ?? string.Empty;
Employee employee = new Employee(employeeNameInput, Convert.ToInt32(employeeSalaryInput));
List<Employee> employeesList = new List<Employee>();

employeesList.Add(employee);
Console.WriteLine($"Added employee {employee.Name} with salary {employee.Salary} to the list.");


