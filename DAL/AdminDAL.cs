using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbank.Model;


namespace Nettbank.DAL
{
    public class AdminDAL
    {
        public Admin findAdmin(Admin admin)
        {
            if (admin.userName == "12345678911" && admin.password == "passord")
            {
                return admin;
            }
            return null;
        }
    }
}
