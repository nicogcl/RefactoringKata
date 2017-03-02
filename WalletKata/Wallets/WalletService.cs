using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;
using System;

namespace WalletKata.Wallets
{
    public class WalletService
    {
        private readonly IWalletProvider walletProvider;
        private readonly IUserSession userSession;

        public WalletService()
            : this(UserSession.GetInstance(), new WalletDAO())
        {

        }

        public WalletService(IUserSession userSession, IWalletProvider walletProvider)
        {
            if (userSession == null)
                throw new ArgumentNullException("userSession");
            if (walletProvider == null)
                throw new ArgumentNullException("walletProvider");

            this.userSession = userSession;
            this.walletProvider = walletProvider;
        }

        public List<Wallet> GetWalletsByUser(User user)
        {
            List<Wallet> walletList = new List<Wallet>();
            IUser loggedUser = userSession.GetLoggedUser();

            if (loggedUser != null)
            {
                if (user.IsFriend(loggedUser))
                {
                    walletList = walletProvider.FindWalletsByUser(user);
                }

                return walletList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }      
        }         
    }
}