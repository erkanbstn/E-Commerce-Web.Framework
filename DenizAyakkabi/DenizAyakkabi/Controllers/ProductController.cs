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
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        ProductValidation pv = new ProductValidation();
        SubCategoryManager sm = new SubCategoryManager(new EFSubCategoryDal());
        public ActionResult MainProduct()
        {
            var x = pm.List();
            return View(x);
        }
        public ActionResult DeleteProduct(int id)
        {
            var x = pm.GetByID(id);
            pm.TDelete(x);
            return RedirectToAction("MainProduct");
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> subc = (from x in sm.List() select new SelectListItem { Text = x.SubCategoryName1, Value = x.SubCategoryID.ToString() }).ToList();
            ViewBag.dgr = subc;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p, HttpPostedFileBase dosya)
        {
            ValidationResult vr = pv.Validate(p);
            if (vr.IsValid)
            {
                if (dosya != null && dosya.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Images/"), dosya.FileName);
                    dosya.SaveAs(path);
                    p.Image = dosya.FileName;
                    pm.TAdd(p);
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

        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> subc = (from x in sm.List() select new SelectListItem { Text = x.SubCategoryName1, Value = x.SubCategoryID.ToString() }).ToList();
            ViewBag.dgr = subc;
            var r = pm.GetByID(id);
            return View(r);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p, HttpPostedFileBase dosya)
        {
            ValidationResult vr = pv.Validate(p);
            if (vr.IsValid)
            {
                if (dosya != null && dosya.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Images/"), dosya.FileName);
                    dosya.SaveAs(path);
                    p.Image = dosya.FileName;
                    pm.TUpdate(p);
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