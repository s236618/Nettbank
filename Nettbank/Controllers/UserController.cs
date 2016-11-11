using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nettbank.BLL;
using Nettbank.Model;

namespace Nettbank.Controllers
{
    public class UserController : Controller
    {
        public ActionResult List()
        {
            var userDb = new UserBLL();
            List<User> allUsers = userDb.showAllUsers();
            return View(allUsers);
        }

        public ActionResult Details(int id)
        {
            var userDb = new UserBLL();
            User aUser = userDb.findUsers(id);
            return View(aUser);
        }

        public ActionResult Userlist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User inUser)
        {
            if (ModelState.IsValid)
            {
                var userDb = new UserBLL();
                bool insertOK = userDb.makeNewUser(inUser);
                if (insertOK)
                {
                    return RedirectToAction("Userlist");
                }
            }
            return View();
        }

        public ActionResult Change(int id)
        {
            var userDb = new UserBLL();
            User aUser = userDb.findUsers(id);
            return View(aUser);
        }

        [HttpPost]
        public ActionResult Change(int id, User changeUser)
        {

            if (ModelState.IsValid)
            {
                var userDb = new UserBLL();
                bool changeOK = userDb.changeUser(id, changeUser);
                if (changeOK)
                {
                    return RedirectToAction("Userlist");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var userDb = new UserBLL();
            User aUser = userDb.findUsers(id);
            return View(aUser);
        }

        [HttpPost]
        public ActionResult Delete(int id, User deleteUser)
        {
            var userDb = new UserBLL();
            bool deleteOK = userDb.deleteUser(id);
            if (deleteOK)
            {
                return RedirectToAction("Userlist");
            }
            return View();
        }

        public ActionResult showUserRegister()
        {
            return RedirectToAction("Userlist");
        }
    }
}