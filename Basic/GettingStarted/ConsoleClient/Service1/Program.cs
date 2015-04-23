using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service1
{
    class Program
    {
        [System.ServiceModel.ServiceContractAttribute(Namespace = "MyService", ConfigurationName = "service.ICalculator")]
        public interface ICalculator
        {
            [System.ServiceModel.OperationContractAttribute(Action = "MyService/ICalculator/Add", ReplyAction = "MyService/ICalculator/AddResponse")]
            double Add(double n1, double n2);

            [System.ServiceModel.OperationContractAttribute(Action = "MyService/ICalculator/Substract", ReplyAction = "MyService/ICalculator/SubstractResponse")]
            double Substract(double n1, double n2);

            [System.ServiceModel.OperationContractAttribute(Action = "MyService/ICalculator/Multiply", ReplyAction = "MyService/ICalculator/MultiplyResponse")]
            double Multiply(double n1, double n2);

            [System.ServiceModel.OperationContractAttribute(Action = "MyService/ICalculator/Devide", ReplyAction = "MyService/ICalculator/DevideResponse")]
            double Devide(double n1, double n2);
        }

        public interface ICalculatorChannel : ICalculator, IClientChannel
        {
        }

        public partial class CalculatorClient :ClientBase<ICalculator>, ICalculator
        {
            public CalculatorClient()
            {
            }

            public CalculatorClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
            {
            }

            public CalculatorClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
            {
            }

            public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
            {
            }

            public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
            {
            }
            public double Add(double n1, double n2)
            {
                return base.Channel.Add(n1, n2);
            }

            public double Substract(double n1, double n2)
            {
                throw new NotImplementedException();
            }

            public double Multiply(double n1, double n2)
            {
                throw new NotImplementedException();
            }

            public double Devide(double n1, double n2)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine(client.Add(20, 21));
            Console.ReadLine();
        }
    }
}
