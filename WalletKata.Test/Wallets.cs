using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletKata.Users;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    internal class Wallets : IWalletProvider
    {
        // TODO : improve IUser 
        private readonly Dictionary<IUser, List<Wallet>> usersWallets = new Dictionary<IUser, List<Wallet>>();

        public List<Wallet> FindWalletsByUser(IUser user)
        {
            List<Wallet> wallets;
            if (usersWallets.TryGetValue(user, out wallets))
                return wallets;
            else
                return new List<Wallet>();
        }

        internal void AddWallet(IUser user, Wallet wallet)
        {
            if (!usersWallets.ContainsKey(user))
                usersWallets[user] = new List<Wallet>();

            usersWallets[user].Add(wallet);
        }
    }
}
