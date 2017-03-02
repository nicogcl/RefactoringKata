using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    public class WalletServiceTest
    {
        [Test]
        public void TestGetWalletByUser1()
        {
            // First goal is to be able to compile/run this kind of code

            // Simplest case
            var wallet = new WalletService();
            var user = new Users.User();

            Users.User loggedUser = null;
            // TODO Mock UserSession 

            user.AddFriend(loggedUser);

            // Link wallets to user
            // TODO
            List<Wallet> userWallets = null;

            // TODO Mock WalletDAO
            var wallets = wallet.GetWalletsByUser(user);

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
