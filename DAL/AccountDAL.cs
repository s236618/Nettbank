using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nettbank;

namespace Nettbank.Model
{
    public class AccountDAL
    {
        public List<Account> showAccounts()
        {
            var db = new AccountContext();
            List<Account> allAccounts = db.Accounts.Select(k => new Account()
            {
                id = k.ID,
                name = k.Name,
                accNumber = k.AccNumber,
                balance = k.Balance
            }).ToList();

            return allAccounts;
        }

        public bool makeNewAccount(Account inAccount)
        {
            var newAccount = new Accounts()
            {
                Name = inAccount.name,
                AccNumber = inAccount.accNumber,
                Balance = inAccount.balance
            };

            var db = new AccountContext();
            db.Accounts.Add(newAccount);
            db.SaveChanges();
            return true;
        }
    }
}