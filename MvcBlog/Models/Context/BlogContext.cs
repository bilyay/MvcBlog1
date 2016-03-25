using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MvcBlog.Models.Entity;

namespace MvcBlog.Models.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        { 
            Database.Connection.ConnectionString = "server=.;Database=OnlineBlog;trusted_connection=true;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
    }
}