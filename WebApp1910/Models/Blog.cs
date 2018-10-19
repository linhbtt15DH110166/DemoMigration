using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApp1910.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class BloggingContext: DbContext
    {
        public BloggingContext() : base("Default") { }
        public DbSet<Blog> Blogs { get; set; }
    }
}