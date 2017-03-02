using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletKata.Users
{
    public interface IUserSession
    {
        IUser GetLoggedUser();
    }
}
