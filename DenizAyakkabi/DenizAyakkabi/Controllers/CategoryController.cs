using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenizAyakkabi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        CategoryValidation cv = new CategoryValidation();
        public ActionResult MainCategory()
        {
            var x = cm.List();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            ValidationResult vr = cv.Validate(c);
            if (vr.IsValid)
            {
                cm.TAdd(c);
                return RedirectToAction("MainCategory");
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
        public ActionResult DeleteCategory(int id)
        {
            var x = cm.GetByID(id);
            cm.TDelete(x);
            return RedirectToAction("MainCategory");
        }


        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var x = cm.GetByID(id);
            return View(x);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category c)
        {
            ValidationResult vr = cv.Validate(c);
            if (vr.IsValid)
            {
                cm.TUpdate(c);
                return RedirectToAction("MainCategory");
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