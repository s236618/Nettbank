using Nettbank.Model;
using Nettbank.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nettbank.Controllers
{ 

    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            if (adminInDb(admin))
            {
                return RedirectToAction("UserList", "User", new { area = "" });
            }
            else
            {
                return View();
            }
        }
        
        public static bool adminInDb(Admin admin)
        {
            using (var db = new AdminContext())
            {
                Admin foundUser = db.Admins.FirstOrDefault(b => b.userName == admin.userName && b.password == admin.password);
                if (foundUser == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
    }
}