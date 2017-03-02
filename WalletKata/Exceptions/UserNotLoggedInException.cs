using System;

namespace WalletKata.Exceptions
{
    public class UserNotLoggedInException : Exception
    {
        // Recommended Microsoft implementation have 3 constructors

        public UserNotLoggedInException()
        {
        }

        public UserNotLoggedInException(string message) : base (message)
        {
        }

        public UserNotLoggedInException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
