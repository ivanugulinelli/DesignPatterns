using DependencyInversionRefactor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor.Classes
{
    /// <summary>
    /// Esta clase donde quedan centralizados todos los posibles cambios que se tengan que hacer.
    /// Esto evita que haya que ir modificar el codigo en todos los lugares donde de implemento.
    /// </summary>
    public static class DataBaseFactory
    {
        public static IDataBase CreateDB()
        {
            //return new DataBaseSQL();

            //o podria usar otra data base...

            return new DataBaseAccess();
        }
    }
}
