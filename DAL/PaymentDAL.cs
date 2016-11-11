using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nettbank.Model;

namespace Nettbank.Model
{
    public class PaymentDAL
    {
        public List<Payment> showAllPayments()
        {
            var db = new PaymentContext();
            List<Payment> allPayments = db.Payments.Select(k => new Payment()
            {
                id = k.ID,
                amount = k.Amount,
                accNumber = k.AccNumber,
                kid = k.Kid,
                date = k.Date
            }).ToList();

            return allPayments;
        }

        public bool makeNewPayment(Payment inPayment)
        {
            var newPayment = new Payments()
            {
                Amount = inPayment.amount,
                AccNumber = inPayment.accNumber,
                Kid = inPayment.kid,
                Date = inPayment.date
            };

                var db = new PaymentContext();
                db.Payments.Add(newPayment);
                db.SaveChanges();
                return true;
        }
        public bool changePayment(int id, Payment inPayment)
        {
            var db = new PaymentContext();
            try
            {
                Payments changePayment = db.Payments.Find(id);
                changePayment.Amount = inPayment.amount;
                changePayment.AccNumber = inPayment.accNumber;
                changePayment.Kid = inPayment.kid;
                
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deletePayment(int deleteId)
        {
            var db = new PaymentContext();
            try
            {
                Payments deletePayment = db.Payments.Find(deleteId);
                db.Payments.Remove(deletePayment);
                db.SaveChanges();
                return true;
            }
            catch (Exception feil)
            {
                return false;
            }
        }
        public Payment findPayments(int id)
        {
            var db = new PaymentContext();

            var DbPayment = db.Payments.Find(id);

            if (DbPayment == null)
            {
                return null;
            }
            else
            {
                var outPayment = new Payment()
                {
                    id = DbPayment.ID,
                    amount = DbPayment.Amount,
                    accNumber = DbPayment.AccNumber,
                    kid = DbPayment.Kid,
                    date = DbPayment.Date,
                };
                return outPayment;
            }
        }
    }
}   