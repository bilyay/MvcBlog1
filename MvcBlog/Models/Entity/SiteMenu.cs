using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MvcBlog.Models.Entity
{
    public class SiteMenu:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; }
    }
}