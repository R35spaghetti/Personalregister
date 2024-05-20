using Personalregister.Contract;

namespace Personalregister.Models;

public class Employee(string name, int salary) : IEmployee
{
    public string Name { get; set;} = name;
    public int Salary { get; set; } = salary;
}