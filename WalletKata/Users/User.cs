using System.Collections;
using System.Collections.Generic;

namespace WalletKata.Users
{
    public class User : IUser
    {
        private List<IUser> friends = new List<IUser>();

        public IEnumerable GetFriends()
        {
            return friends;
        }

        public void AddFriend(IUser friend)
        {
            friends.Add(friend);
        }
    }
}