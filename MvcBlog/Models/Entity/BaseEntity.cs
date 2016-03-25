using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        private DateTime? _addDate = DateTime.Now;

        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        private bool _isDeleted = false;

        public bool IsDeleted
        {
            get { return _isDeleted; } 
            set { _isDeleted = value; }
        }

        public DateTime? DeletedDate  { get; set; }
    }
}