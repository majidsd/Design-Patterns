using Composite.EmployeeSample;

#region Employee Demo Sample
IEmployee cashier1 = new Cashier(4, "Ahmed", 65000.0);
IEmployee cashier2 = new Cashier(3, "Ali", 65000.0);

cashier1.Print();
cashier2.Print();

IEmployee accountant = new Accountant(2, "Mustafa", 80000.0);
accountant.Print();

IEmployee manager = new BankManager(1, "Mohammed", 100000.0);
manager.Print();

manager.Add(cashier1);
manager.Add(cashier2);
manager.Add(accountant);
manager.Print();
#endregion

Console.WriteLine("Done!");
