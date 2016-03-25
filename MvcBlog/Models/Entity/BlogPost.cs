using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcBlog.Models.Entity
{
    public class BlogPost:BaseEntity
    {
        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}