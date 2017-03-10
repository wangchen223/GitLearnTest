using Beisen.ESBDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Beisen.ESBDemo.ServiceInterface
{
    [ServiceContract]
    public interface IUserProvider
    {
        [OperationContract(Action = "AddUser")]
        string AddUser(UserDTO model);
    }
}
