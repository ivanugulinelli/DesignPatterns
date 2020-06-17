using DependencyInversionRefactor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor.Classes
{
    class DataBaseAccess : IDataBase
    {
        private string LocalStorage;

        public DataBaseAccess()
        {
            LocalStorage = "Access ready...";
        }

        public void Save(string Data)
        {
            LocalStorage += " + " + Data;
        }
    }
}
