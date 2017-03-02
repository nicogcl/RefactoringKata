using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletKata.Users
{
    public interface IUser
    {
        IReadOnlyCollection<IUser> GetFriends();

        void AddFriend(IUser friend);

        bool IsFriend(IUser user);
    }
}
