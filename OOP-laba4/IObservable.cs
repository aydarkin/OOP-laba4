using System.Collections.Generic;

namespace OOP_laba4
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void RemoveAllObserver();
        List<IObserver> GetObservers();

        bool isObserver(IObserver observer);
        void NotifyAll(string property = null, object[] args = null);
    }
}
