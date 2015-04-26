using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XmlAjaxService
{
    // Define a service contract.
    [ServiceContract(Namespace = "XmlAjaxService")]
    public interface ICalculator
    {
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        MathResult DoMathJson(double n1, double n2);

        [WebInvoke(ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped)]
        MathResult DoMathXml(double n1, double n2);

    }

    [DataContract]
    public class MathResult
    {
        [DataMember]
        public double sum;

        [DataMember]
        public double difference;

        [DataMember]
        public double product;

        [DataMember]
        public double quotient;
    }

}
