using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbank;
using Nettbank.Model;

namespace Nettbank.BLL
{
    public class AccountBLL
    {
        public List<Account> showAccounts()
        {
            var userDal = new AccountDAL();
            return userDal.showAccounts ();
        }

        public bool makeNewAccount(Account inAccount)
        {
            var accountDal = new AccountDAL();
            return accountDal.makeNewAccount(inAccount);
        }

    }
}
