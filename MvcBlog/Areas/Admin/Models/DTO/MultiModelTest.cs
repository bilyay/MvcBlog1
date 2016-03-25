using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBlog.Models.Entity;

namespace MvcBlog.Areas.Admin.Models.DTO
{
    public class MultiModelTest
    {
        public List<Category> Categories { get; set; }
        public List<AdminUser> AdminUsers { get; set; }
    }
}