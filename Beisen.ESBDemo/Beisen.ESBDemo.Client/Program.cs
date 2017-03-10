using Beisen.ESBDemo.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Beisen.ESBDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:8081/User");
            WSHttpBinding binding = new WSHttpBinding();

            ChannelFactory<IUserProvider> factory = new ChannelFactory<IUserProvider>(binding, address);

            IUserProvider channel = factory.CreateChannel();

            string result = channel.AddUser(new Model.UserDTO { Name = "测试" });

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
