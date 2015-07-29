namespace New.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LawBlog : DbContext
    {
        public LawBlog()
            : base("name=LawBlog")
        {
        }


        public virtual DbSet<Post> Posts { get; set; }
   
       
    }
}
