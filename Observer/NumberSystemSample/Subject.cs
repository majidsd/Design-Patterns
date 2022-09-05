
using System.Collections.Generic;

namespace Observer.NumberSystemSample;

public class Subject
{
    private readonly List<IObserver> observers = new();
    private int state;

    public int GetState()
    {
        return state;
    }

    public void SetState(int state)
    {
        this.state = state;
        NotifyAllObservers();
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyAllObservers()
    {
        foreach(var observer in observers)
        {
            observer.Update();
        }
    }
}
