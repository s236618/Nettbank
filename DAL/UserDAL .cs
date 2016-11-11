using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nettbank.Model;
using System.Data.SqlClient;
using System.Data;

namespace Nettbank.DAL
{
    public class UserDAL
    {

        public User findUsers(User user)
        {
            if (user.persNr == 12345678911 && user.password == "passord")
            {
                return user;
            }
            return null;
        }

        public List<User> showAllUsers()
        {
            var db = new UserContext();
            List<User> allUsers = db.Users.Select(k => new User()
            {
                persNr = k.PersNr,
                password = k.Passord
            }).ToList();

            return allUsers;
        }

        public bool makeNewUser(User inUser)
        {
            var newUser = new Users()
            {
                PersNr = inUser.persNr,
                Passord = inUser.password
            };

            var db = new UserContext();
            db.Users.Add(newUser);
            db.SaveChanges();
            return true;
        }

        public bool changeUser(int id, User inUser)
        {
            var db = new UserContext();
            try
            {
                Users changeUser = db.Users.Find(id);
                changeUser.PersNr = inUser.persNr;
                changeUser.Passord = inUser.password;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteUser(int deleteId)
        {
            var db = new UserContext();
            try
            {
                Users deleteUser = db.Users.Find(deleteId);
                db.Users.Remove(deleteUser);
                db.SaveChanges();
                return true;
            }
            catch (Exception feil)
            {
                return false;
            }
        }

        public User findUsers(int id)
        {
            var db = new UserContext();

            var DbUser = db.Users.Find(id);

            if (DbUser == null)
            {
                return null;
            }
            else
            {
                var outUser = new User()
                {
                    persNr = DbUser.PersNr,
                    password = DbUser.Passord
                };
                return outUser;
            }
        }

    }
}