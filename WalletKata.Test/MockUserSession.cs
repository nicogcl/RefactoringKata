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
        private readonly User loggedUser;

        internal MockUserSession(User user)
        {
            this.loggedUser = user;
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
