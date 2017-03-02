using System.Collections;
using System.Collections.Generic;

namespace WalletKata.Users
{
    public class User : IUser
    {
        private List<IUser> friends = new List<IUser>();

        public IEnumerable<IUser> GetFriends()
        {
            return friends;
        }

        public void AddFriend(IUser friend)
        {
            friends.Add(friend);
        }

        /// <summary>
        /// Check if passed user is a friend 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true if user is a friend or false else. Null user is not a friend</returns>
        public bool IsFriend(IUser user)
        {
            if (user == null)
                return false;

            foreach (User friend in GetFriends())
            {
                if (friend.Equals(user))
                    return true;
            }
            return false;
        }
    }
}