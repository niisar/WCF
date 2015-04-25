using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
namespace Service
{
    [ServiceContract(Namespace = "JsonAjaxService")]
    public interface IService1
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        Customer GetCustomer();
    }


    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
    }
}
