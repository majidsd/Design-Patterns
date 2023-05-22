
namespace Composite.EmployeeSample;

internal class Cashier : IEmployee
{
    private readonly int _id;
    private readonly string _name;
    private readonly double _salary;

    public Cashier(int id, string name, double salary) =>
        (_id, _name, _salary) = (id, name, salary);

    public void Add(IEmployee employee)
    {
        // This is a leaf that don't have subs
    }

    public IEmployee GetChild(int Id)
    {
        // This is a leaf that don't have subs
        return null;
    }

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

    public void Print()
    {
        Console.WriteLine("==============================================");

        Console.WriteLine($"Id = {GetId()}");
        Console.WriteLine($"Name = {GetName()}");
        Console.WriteLine($"Salary = {GetSalary()}");

        Console.WriteLine("==============================================");
    }

    public void Remove(IEmployee employee)
    {
        // This is a leaf that don't have subs
    }
}
