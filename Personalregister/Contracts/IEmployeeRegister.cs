using Personalregister.Models;

namespace Personalregister.Contracts;

public interface IEmployeeRegister
{
    void PresentRegister(List<Employee> employees);
}

