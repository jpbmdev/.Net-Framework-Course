using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSPerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPersons
    {
        [OperationContract]
        Person GetPersonById(int ID);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Person : BaseResponse
    {
        [DataMember]
        public int ID { get; set; }
        
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int YearOld { get; set; }
    }

    [DataContract]
    public class BaseResponse
    {
        [DataMember]
        public string MessageResponses { get; set; }

        [DataMember]
        public string Error { get; set; }
    }


}
