using Beisen.ESBDemo.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beisen.ESBDemo.Model;

namespace Beisen.ESBDemo.ServiceImp
{
    public class UserProvider : IUserProvider
    {
        #region Singleton
        private static readonly IUserProvider instance = new UserProvider();

        public static IUserProvider Instance
        {
            get { return instance; }
        }

        private UserProvider()
        {
        }
        #endregion

        public string AddUser(UserDTO model)
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }
    }
}
