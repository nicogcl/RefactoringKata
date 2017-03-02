using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WalletKata.Users;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    public class WalletServiceTest
    {
        [Test]
        public void TestGetWalletByUser1()
        {
             // Simplest test case

            Users.User loggedUser = new User();

            var userSession = new MockUserSession(loggedUser);
            Wallets walletProvider = new Wallets();

            var user = new Users.User();
            user.AddFriend(loggedUser);

            // Link wallets to user
            var wallet = new Wallet();
            walletProvider.AddWallet(user, wallet);
            List<Wallet> userWallets = walletProvider.FindWalletsByUser(user);

            var walletSvc = new WalletService(userSession, walletProvider);
            var wallets = walletSvc.GetWalletsByUser(user);

            // Does NUnit Assert work on container(object)..?
            Assert.IsNotNull(wallets);
            Assert.AreEqual(userWallets.Count, wallets.Count);
            for (int i = 0; i < userWallets.Count; ++i)
            {
                // TODO Implement Equals on Wallet
                Assert.AreEqual(userWallets[i], wallets[i]);
            }
        }
    }
}
