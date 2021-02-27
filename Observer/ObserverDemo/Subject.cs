using System.Collections.Generic;

namespace ObserverDemo
{
    public class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserver(double price)
        {
            foreach (var observer in observers)
            {
                observer.Update(price);
            }
        }
    }
}
