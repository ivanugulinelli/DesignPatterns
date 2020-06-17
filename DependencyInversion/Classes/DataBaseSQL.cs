using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Classes
{
    class DataBaseSQL
    {
        private string LocalStorage;

        public DataBaseSQL()
        {
            LocalStorage = "SQL Server ready...";
        }

        public void Save(string Data)
        {
            LocalStorage += " - " + Data;
        }
    }
}
