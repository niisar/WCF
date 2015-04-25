using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleAjaxService
{
    public class Service1 : ICalculator
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mul(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
