﻿using Personalregister.Models;

int choice;
List<Employee> employeesList = [];
EmployeeRegister employeeRegister = new EmployeeRegister();
do
{
    Console.WriteLine("Enter the number to choose \n" +
                      " 1 - Add employee \n" +
                      " 2 - Show all employees \n" +
                      " 3 - Exit program");
    bool validChoice = Int32.TryParse(Console.ReadLine(), out choice);

    if (!validChoice)
    {
        ErrorMessageInvalidChoice();
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter employee's name");
            string employeeNameInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter employee's salary");
            string employeeSalaryInput = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(employeeSalaryInput, out _))
            {
                Employee employee = new Employee(employeeNameInput, Convert.ToInt32(employeeSalaryInput));
                employeesList.Add(employee);
                Console.WriteLine($"Added employee {employee.Name} with salary {employee.Salary} to the list.");
            }
            else
            {
                Console.WriteLine("Invalid salary input, returning to menu");
            }

            break;
        case 2:
            Console.WriteLine("List of employees:");
            employeeRegister.PresentRegister(employeesList);


            break;
        case 3:
            Console.WriteLine("Exits program..");
            break;
    }
} while (choice != 3);

void ErrorMessageInvalidChoice()
{
    Console.WriteLine("Invalid choice, please enter a number between 1-3");
}