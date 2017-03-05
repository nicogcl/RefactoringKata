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
        private readonly Dictionary<User, List<Wallet>> usersWallets = new Dictionary<User, List<Wallet>>();

        public List<Wallet> FindWalletsByUser(User user)
        {
            List<Wallet> wallets;
            if (usersWallets.TryGetValue(user, out wallets))
                return wallets;
            else
                return new List<Wallet>();
        }

        internal void AddWallet(User user, Wallet wallet)
        {
            if (!usersWallets.ContainsKey(user))
                usersWallets[user] = new List<Wallet>();

            usersWallets[user].Add(wallet);
        }
    }
}
