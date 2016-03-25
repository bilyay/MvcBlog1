using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlog.Models.Entity
{
    public class AdminUser:BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}