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
        [WebGet]
        double Add(double n1, double n2);
        [WebGet]
        double Sub(double n1, double n2);
        [WebGet]
        double Mul(double n1, double n2);
        [WebGet]
        double Div(double n1, double n2);
    }
}
