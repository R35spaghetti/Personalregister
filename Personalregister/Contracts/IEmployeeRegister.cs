using Personalregister.Models;

namespace Personalregister.Contracts;

public interface IEmployeeRegister
{   
    List<Employee> Employees { get; set; }
    void PresentRegister(List<Employee> employees);
}

