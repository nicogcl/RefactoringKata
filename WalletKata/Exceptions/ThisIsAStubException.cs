using System;

namespace WalletKata.Exceptions
{
    public class ThisIsAStubException : Exception
    {
        // Recommended Microsoft implementation have 3 constructors

        public ThisIsAStubException() 
        {
        }

        public ThisIsAStubException(string message) : base (message)
        {
        }

        public ThisIsAStubException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}