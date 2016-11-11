using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbank.Model;
using Nettbank.DAL;

namespace Nettbank.BLL
{
    public class PaymentBLL
    {
        public List<Payment> showAllPayments()
        {
            var paymentDal = new PaymentDAL();
            return paymentDal.showAllPayments();
        }

        public bool makeNewPayment(Payment inPayment)
        {
            var paymentDal = new PaymentDAL();
            return paymentDal.makeNewPayment(inPayment);
        }

        public bool changePayment(int id, Payment inPayment)
        {
            var paymentDal = new PaymentDAL();
            return paymentDal.changePayment(id, inPayment);
        }

        public bool deletePayment (int id)
        {
            var paymentDal = new PaymentDAL();
            return paymentDal.deletePayment(id);
        }

        public Payment findPayments(int id)
        {
            var paymentDal = new PaymentDAL();
            return paymentDal.findPayments(id);
        }
    }
}
