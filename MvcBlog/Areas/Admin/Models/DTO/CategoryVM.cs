using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlog.Areas.Admin.Models.DTO
{
    public class CategoryVM: BaseVM
    {
        [Required(ErrorMessage = "Lütfen Kategori Adı Giriniz!")]
        [Display(Name="Kategori Adı")]
        public string Name { get; set; }
     
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
}