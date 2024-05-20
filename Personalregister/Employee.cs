using Personalregister.Contract;

namespace Personalregister;

public class Employee(string name, int salary) : IEmployee
{
    public string Name { get; set;} = name;
    public int Salary { get; set; } = salary;
}