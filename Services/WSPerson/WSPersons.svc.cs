using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSPerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSPersons : IWSPersons
    {
        public Person GetPersonById(int ID)
        {
            if (ID == 0)
            {
                return new Person() { ID = 0, FirstName = "Pedro", LastName = "Ruiz", YearOld = 20 };
            }
            else if (ID == 1)
            {
                return new Person() { ID = 1, FirstName = "Maria", LastName = "Diaz", YearOld = 24 };
            }
            else if (ID == 2)
            {
                return new Person() { ID = 3, FirstName = "Juan", LastName = "Lopez", YearOld = 26 };
            }
            else
            {
                return new Person() { Error = "No se encontro la persona." };
            }
        }
    }
}
