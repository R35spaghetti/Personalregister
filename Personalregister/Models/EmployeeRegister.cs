using Personalregister.Contracts;

namespace Personalregister.Models;

public class EmployeeRegister : IEmployeeRegister
{
    public void PresentRegister(List<Employee> employees)
    {
        foreach (var item in employees)
        {
            Console.WriteLine($"Employee {item.Name} with salary {item.Salary}");
        }
        
    }
}