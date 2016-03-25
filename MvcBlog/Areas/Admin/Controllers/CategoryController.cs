using MvcBlog.Areas.Admin.Models.DTO;
using MvcBlog.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {

        public ActionResult Index()
        {
            List<CategoryVM> model =
               db.Categories.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new CategoryVM()
               {
                   Name = x.Name,
                   Description = x.Description,
                   Id = x.Id
               }).ToList();
            return View(model);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category cat = new Category();
                cat.Name = model.Name;
                cat.Description = model.Description;
                db.Categories.Add(cat);
                db.SaveChanges();
                ViewBag.IslemDurumu = 1;
            }
            else
            {
                ViewBag.IslemDurumu = 0;
            }
            return View();
        }

        public ActionResult UpdateCategory(int id)
        {
            Category cat = db.Categories.FirstOrDefault(x => x.Id == id);
            CategoryVM model=new CategoryVM();
            model.Name = cat.Name;
            model.Description = cat.Description;
            return View(model);

        }
        [HttpPost]
        public ActionResult UpdateCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category cat = db.Categories.FirstOrDefault(x => x.Id == model.Id);
                cat.Name = model.Name;
                cat.Description = model.Description;
                db.SaveChanges();
                ViewBag.IslemDurumu = 1;
                return RedirectToAction("Index","Category");
            }
            else
            {
                ViewBag.IslemDurumu = 0;
                return View(model);
            }
           
            

        }

        public JsonResult DeleteCategory(int id)
        {
            Category cat =db.Categories.FirstOrDefault(x=>x.Id==id);
            cat.IsDeleted = true;
            cat.DeletedDate = DateTime.Now;
            db.SaveChanges();
            return Json("");

        }
    }
}