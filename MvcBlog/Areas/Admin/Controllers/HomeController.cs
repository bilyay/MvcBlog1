using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Areas.Admin.Models.Attributes;
using MvcBlog.Models.Context;
using MvcBlog.Models.Entity;

namespace MvcBlog.Areas.Admin.Controllers
{
    [LoginControl]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //BlogContext db=new BlogContext();
            //string email = HttpContext.User.Identity.Name;
            //AdminUser adminUser = db.AdminUsers.FirstOrDefault(x => x.Email == email);
            //string name = adminUser.Name;
            //string surname = adminUser.Surname;

            return View();
        }
    }
}