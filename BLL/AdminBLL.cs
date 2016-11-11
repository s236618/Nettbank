using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbank.Model;
using Nettbank.DAL;

namespace Nettbank.BLL
{
    public class AdminBLL
    {
        public Admin findAdmin(Admin admin)
        {
            var adminDal = new AdminDAL();
            return adminDal.findAdmin(admin);
        }
    }
}
