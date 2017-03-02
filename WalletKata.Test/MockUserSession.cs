using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletKata.Users;

namespace WalletKata.Test
{
    internal class MockUserSession : IUserSession
    {
        private readonly IUser loggedUser;

        internal MockUserSession(IUser user)
        {
            this.loggedUser = user;
        }

        public IUser GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
