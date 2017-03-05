using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletKata.Users
{
    public interface IUserSession
    {
        /// <summary>
        /// Get current logged user
        /// </summary>
        /// <returns>Currently logged user or null if no user</returns>
        User GetLoggedUser();
    }
}
