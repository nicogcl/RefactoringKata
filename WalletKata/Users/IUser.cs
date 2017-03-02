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

        /// <summary>
        /// Add a new friend
        /// </summary>
        /// <param name="friend">New friend to add</param>
        /// <exception cref="ArgumentNullException">If friend is null</exception>
        void AddFriend(IUser friend);

        /// <summary>
        /// Check if passed user is a friend 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true if user is a friend or false else. Null user is not a friend</returns>
        bool IsFriend(IUser user);
    }
}
