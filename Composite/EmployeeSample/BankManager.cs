
namespace Composite.EmployeeSample;

internal class BankManager : IEmployee
{
    private readonly int _id;
    private readonly string _name;
    private readonly double _salary;
    private readonly List<IEmployee> _subordinates;

    public BankManager(int id, string name, double salary) => 
        (_id, _name, _salary, _subordinates) = (id, name, salary, new List<IEmployee>());

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public void Add(IEmployee employee)
    {
        _subordinates.Add(employee);
    }

    public void Remove(IEmployee employee)
    {
        _subordinates.Remove(employee);
    }

    public IEmployee GetChild(int id)
    {
        return _subordinates[id];
    }

    public void Print()
    {
        Console.WriteLine("==============================================");

        Console.WriteLine($"Id = {GetId()}");
        Console.WriteLine($"Name = {GetName()}");
        Console.WriteLine($"Salary = {GetSalary()}");

        Console.WriteLine("==============================================");

        foreach(var employee in _subordinates)
        {
            employee.Print();
        }
    }
}
