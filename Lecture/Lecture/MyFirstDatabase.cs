namespace Lecture
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyFirstDatabase : DbContext
    {
        public MyFirstDatabase()
            : base("name=MyFirstDatabase")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Panda> Pandas { get; set; }
        public virtual DbSet<Zoo> Zoos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Gender>()
            //    .HasMany(e => e.Pandas)
            //    .WithRequired(e => e.Gender)
            //    .HasForeignKey(e => e.Gender_Id)
            //    .WillCascadeOnDelete(false);

        
        }
    }
}
