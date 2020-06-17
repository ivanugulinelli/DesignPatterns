using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    class ConcreteObserver : IObserver
    {
        public void Update(SubjectEvent subjectEvent)
        {
            Console.WriteLine("");
            Console.WriteLine("An event just happened!");
            Console.WriteLine("Event type: " + subjectEvent.EventType);
            Console.WriteLine("Event date: " + subjectEvent.EventDate);
        }
    }
}
