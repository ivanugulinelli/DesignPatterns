using Observer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    interface IObserver
    {
        void Update(SubjectEvent subjectEvent);
    }
}
