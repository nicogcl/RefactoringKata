using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using WalletKata.Exceptions;
using WalletKata.Users;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    public class WalletServiceTest
    {
        [Test]
        public void TestGetWalletByUser1()
        {
            Users.User loggedUser = new User("user1");

            var userSession = new MockUserSession(loggedUser);
            Wallets walletProvider = new Wallets();

            var user = new Users.User("user2");
            user.AddFriend(loggedUser);

            // Link wallets to user
            walletProvider.AddWallet(user, new Wallet("wallet1"));
            walletProvider.AddWallet(user, new Wallet("wallet2"));
            walletProvider.AddWallet(user, new Wallet("wallet3"));

            List<Wallet> userWallets = walletProvider.FindWalletsByUser(user);

            var walletSvc = new WalletService(userSession, walletProvider);
            var wallets = walletSvc.GetWalletsByUser(user);

            // Does NUnit Assert work on container(object)..?
            Assert.IsNotNull(wallets);
            Assert.AreEqual(userWallets.Count, wallets.Count);
            for (int i = 0; i < userWallets.Count; ++i)
            {
                Assert.AreEqual(userWallets[i], wallets[i]);
            }
        }

        [Test]
        public void TestGetWalletByUserNoUser()
        {
            var userSession = new MockUserSession(null);
            Wallets walletProvider = new Wallets();

            var user = new Users.User("user1");

            var walletSvc = new WalletService(userSession, walletProvider);
            Assert.Throws<UserNotLoggedInException>(() => walletSvc.GetWalletsByUser(user));
        }


        [Test]
        public void TestGetWalletByUserNotFriend()
        {
            Users.User loggedUser = new User("user1");

            var userSession = new MockUserSession(loggedUser);
            Wallets walletProvider = new Wallets();

            var user = new Users.User("user2");

            // Link wallets to user
            var wallet = new Wallet("wallet1");
            walletProvider.AddWallet(user, wallet);
            List<Wallet> userWallets = walletProvider.FindWalletsByUser(user);

            var walletSvc = new WalletService(userSession, walletProvider);
            var wallets = walletSvc.GetWalletsByUser(user);
            Assert.IsNotNull(wallets);
            Assert.AreEqual(0, wallets.Count);
        }

        [Test]
        public void TestGetWalletByUserNull()
        {
            Users.User loggedUser = new User("user1");

            var userSession = new MockUserSession(loggedUser);
            Wallets walletProvider = new Wallets();

            var walletSvc = new WalletService(userSession, walletProvider);
            Assert.Throws<ArgumentNullException>(() => walletSvc.GetWalletsByUser(null));
        }
    }
}
