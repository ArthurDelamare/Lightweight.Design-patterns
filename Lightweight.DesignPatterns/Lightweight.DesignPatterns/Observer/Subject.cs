using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight.DesignPatterns.Observer
{
    public class Subject : ISubject
    {
        protected List<IObserver> _observers = new List<IObserver>();

        public void Notify()
        {
            this._observers.ForEach(observer => observer.Update());
        }

        public void Subscribe(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public int Count
        {
            get
            {
                return this._observers.Count;
            }
        }
    }
}
