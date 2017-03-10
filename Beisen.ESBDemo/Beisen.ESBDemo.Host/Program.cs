using Beisen.ESBDemo.ServiceImp;
using Beisen.ESBDemo.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Beisen.ESBDemo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uri baseAddress = new Uri("http://localhost:8081/User");

            Binding wsBinding = new WSHttpBinding();
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(UserProvider));
            host.AddServiceEndpoint(typeof(IUserProvider), wsBinding,
"http://localhost:8081/User");
            host.Open();
            Console.WriteLine("Service Open");
            Console.ReadLine();
            host.Close();
        }
    }
}
