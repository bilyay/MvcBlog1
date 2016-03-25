using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcBlog.Areas.Admin.Models.DTO;
using MvcBlog.Models.Context;

namespace MvcBlog.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.AdminUsers.Any(x=>x.Email==model.Email&&x.Password==model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email,true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return View();
        }
    }
}