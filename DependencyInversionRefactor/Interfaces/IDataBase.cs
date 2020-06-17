using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor.Interfaces
{
    public interface IDataBase
    {
        void Save(string Data);
    }
}
