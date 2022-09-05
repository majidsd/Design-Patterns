
using System;

namespace Singleton;

public class SingleObjectClass
{
    private static readonly SingleObjectClass _instance = new ();

    private SingleObjectClass()
    {
    }

    public static SingleObjectClass GetInstance()
    {
        return _instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("A message from your object 'created one time and used everytime.'");
    } 
}
