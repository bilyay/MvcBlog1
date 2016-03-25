using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlog.Areas.Admin.Models.DTO
{
    public class LoginModel: BaseVM
    {
        [Required (ErrorMessage = "Lütfen email giriniz.")]
        [EmailAddress(ErrorMessage = "Email adresi hatalı.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Paralo Giriniz.")]
        public string Password { get; set; }
    }
}