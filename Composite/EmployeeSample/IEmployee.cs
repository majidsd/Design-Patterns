
namespace Composite.EmployeeSample;

internal interface IEmployee
{
    int GetId();
    string GetName();
    double GetSalary();
    void Print();

    void Add(IEmployee employee);
    void Remove(IEmployee employee);
    IEmployee GetChild(int Id);
}
