using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenizAyakkabi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EFAboutDal());
        AboutValidation av = new AboutValidation();
        public ActionResult MainAbout()
        {
            var x = am.List();
            return View(x);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var b = am.GetByID(id);
            return View(b);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About a, HttpPostedFileBase dosya)
        {
            ValidationResult vr = av.Validate(a);
            if (vr.IsValid)
            {
                if (dosya != null && dosya.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Images/"), dosya.FileName);
                    dosya.SaveAs(path);
                    a.Image = dosya.FileName;
                    am.TUpdate(a);
                }
                return RedirectToAction("MainProduct");
            }
            else
            {
                foreach (var item in vr.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}