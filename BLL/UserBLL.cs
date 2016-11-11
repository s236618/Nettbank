using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbank.Model;
using Nettbank.DAL;

namespace Nettbank.BLL
{
    public class UserBLL
    {
        public List<User> showAllUsers()
        {
            var userDal = new UserDAL();
            return userDal.showAllUsers();
        }

        public bool makeNewUser(User inUser)
        {
            var userDal = new UserDAL();
            return userDal.makeNewUser(inUser);
        }

        public bool changeUser(int id, User inUser)
        {
            var userDal = new UserDAL();
            return userDal.changeUser(id, inUser);
        }

        public bool deleteUser(int id)
        {
            var userDal = new UserDAL();
            return userDal.deleteUser(id);
        }

        public User findUsers(int id)
        {
            var userDal = new UserDAL();
            return userDal.findUsers(id);
        }

    }
}
