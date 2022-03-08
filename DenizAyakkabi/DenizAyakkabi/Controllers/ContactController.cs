using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenizAyakkabi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDal());
        public ActionResult MainContact()
        {
            var x = cm.List();
            return View(x);
        }
        public ActionResult DeleteContact(int id)
        {
            var x = cm.GetByID(id);
            cm.TDelete(x);
            return RedirectToAction("MainContact");
        }

        public ActionResult ViewContact(int id)
        {
            var x = cm.GetByID(id);
            return View(x);
        }
    }
}
