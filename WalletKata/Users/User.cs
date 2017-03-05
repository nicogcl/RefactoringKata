using System;
using System.Collections;
using System.Collections.Generic;

namespace WalletKata.Users
{
    public class User
    {
        /// <summary>
        /// Unique user identifier
        /// </summary>
        /// <remarks>Comparing object reference is not good 
        /// I choose to add a member acting as a unique identifier for user
        /// User comparison is based on this id.
        /// </remarks>
        private readonly String id;

        private List<User> friends = new List<User>();

        public User(String id)
        {
            if (String.IsNullOrEmpty(id))
                throw new ArgumentNullException("id");
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User user = (User)obj;
            return (user.id == id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public IReadOnlyCollection<User> GetFriends()
        {
            return friends.AsReadOnly();
        }

        public void AddFriend(User friend)
        {
            if (friend == null)
                throw new ArgumentNullException("friend");

            // Could check if is not already in the friends list
            friends.Add(friend);
        }

        /// <summary>
        /// Check if passed user is a friend 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true if user is a friend or false else. Null user is not a friend</returns>
        public bool IsFriend(User user)
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
