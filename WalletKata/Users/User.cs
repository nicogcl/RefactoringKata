using System;
using System.Collections;
using System.Collections.Generic;

namespace WalletKata.Users
{
    // TODO : Should implements Equals and use a member as a user identifier
    public class User : IUser
    {
        private List<IUser> friends = new List<IUser>();

        public IReadOnlyCollection<IUser> GetFriends()
        {
            return friends.AsReadOnly();
        }

        public void AddFriend(IUser friend)
        {
            if (friend == null)
                throw new ArgumentNullException("friend");

            // TODO : Check if is not already in the friends list
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