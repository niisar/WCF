using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
namespace XmlAjaxService
{
    public class Service1 : ICalculator
    {

        public MathResult DoMathJson(double n1, double n2)
        {
            return DoMath(n1, n2);
        }

        public MathResult DoMathXml(double n1, double n2)
        {
            return DoMath(n1, n2);
        }

        private MathResult DoMath(double n1, double n2)
        {
            MathResult mr = new MathResult();
            mr.sum = n1 + n2;
            mr.difference = n1 - n2;
            mr.product = n1 * n2;
            mr.quotient = n1 / n2;
            return mr;
        }
    }
}
