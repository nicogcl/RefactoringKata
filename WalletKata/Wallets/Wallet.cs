using System;

namespace WalletKata.Wallets
{
    public class Wallet
    {
        /// </summary>
        /// <remarks>Comparing object reference is not good 
        /// I choose to add a member acting as a unique identifier for wallet
        /// Comparison is based on this id.
        /// </remarks>
        private readonly String id;

        public Wallet(String id)
        {
            if (String.IsNullOrEmpty(id))
                throw new ArgumentNullException("id");
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Wallet w = (Wallet)obj;
            return (w.id == id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
