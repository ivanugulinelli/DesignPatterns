using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers;

        public ConcreteSubject()
        {
            _observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(SubjectEvent subjectEvent)
        {
            foreach (var observer in _observers)
            {
                observer.Update(subjectEvent);
            }
        }

        public void AddProduct()
        {
            //aca va la logica de agregado de productos

            SubjectEvent subjectEvent = new SubjectEvent { EventType = "Tipo de evento", EventDate = DateTime.Now };

            NotifyObservers(subjectEvent);
        }
    }
}
