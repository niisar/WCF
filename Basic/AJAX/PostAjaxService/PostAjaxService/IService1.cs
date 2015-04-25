using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleAjaxService
{
    [ServiceContract(Namespace="SimpleAjexSample")]
    public interface ICalculator
    {
        [WebInvoke]
        double Add(double n1, double n2);
        [WebInvoke]
        double Sub(double n1, double n2);
        [WebInvoke]
        double Mul(double n1, double n2);
        [WebInvoke]
        double Div(double n1, double n2);
    }
}
