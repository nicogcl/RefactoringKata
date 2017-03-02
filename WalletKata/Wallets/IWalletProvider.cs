using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletKata.Users;

namespace WalletKata.Wallets
{
    public interface IWalletProvider
    {
        List<Wallet> FindWalletsByUser(IUser user);
    }
}
