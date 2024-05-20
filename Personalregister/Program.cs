using Personalregister.Models;

int choice;
List<Employee> employeesList = new List<Employee>();

do
{
    Console.WriteLine("Enter the number to choose \n" +
                      " 0 - Add employee \n" +
                      " 1 - Show all employees \n" +
                      " 2 - Exit program");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 0:
            Console.WriteLine("Enter employee's name");
            string employeeNameInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter employee's salary");
            string employeeSalaryInput = Console.ReadLine() ?? string.Empty;
            Employee employee = new Employee(employeeNameInput, Convert.ToInt32(employeeSalaryInput));

            employeesList.Add(employee);
            Console.WriteLine($"Added employee {employee.Name} with salary {employee.Salary} to the list.");
            break;
        case 1:
            Console.WriteLine("List of employees:");
            foreach (var item in employeesList)
            {
                Console.WriteLine($"Employee {item.Name} with salary {item.Salary}");
            }

            break;
        case 2:
            Console.WriteLine("Exits program..");
            break;
        default:
            Console.WriteLine("Invalid choice, enter either 1 or 0.");
            break;
    }
} while (choice != 2);