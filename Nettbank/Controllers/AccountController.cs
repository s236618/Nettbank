using Nettbank.BLL;
using Nettbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nettbank.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult AccountOverview()
        {
            var AccountBLL = new AccountBLL();
            List<Account> allAccounts = AccountBLL.showAccounts();
            return View(allAccounts);
        }

    }
}