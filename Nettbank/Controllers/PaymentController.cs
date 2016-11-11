using Nettbank.Model;
using Nettbank.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nettbank.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult List()
        {
            var paymentDb = new PaymentBLL();
            List<Payment> allPayments = paymentDb.showAllPayments();
            return View(allPayments);
        }

        public ActionResult Details(int id)
        {
            var paymentDb = new PaymentBLL();
            Payment aPayment = paymentDb.findPayments(id);
            return View(aPayment);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Payment inPayment)
        {
            if (ModelState.IsValid)
            {
                var paymentDb = new PaymentBLL();
                bool insertOK = paymentDb.makeNewPayment(inPayment);
                if (insertOK)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }

        public ActionResult Change(int id)
        {
            var paymentDb = new PaymentBLL();
            Payment aPayment = paymentDb.findPayments(id);
            return View(aPayment);
        }

        [HttpPost]
        public ActionResult Change(int id, Payment changePayment)
        {

            if (ModelState.IsValid)
            {
                var paymentDb = new PaymentBLL();
                bool changeOK = paymentDb.changePayment(id, changePayment);
                if (changeOK)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var paymentDb = new PaymentBLL();
            Payment aPayment = paymentDb.findPayments(id);
            return View(aPayment);
        }

        [HttpPost]
        public ActionResult Delete(int id, Payment deletePayment)
        {
            var paymentDb = new PaymentBLL();
            bool deleteOK = paymentDb.deletePayment(id);
            if (deleteOK)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult showPaymentRegister()
        {
            return RedirectToAction("List");
        }
    }
}
