namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lecture.MyFirstDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lecture.MyFirstDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Genders.AddOrUpdate(g => g.abbr,
                new Gender { abbr = "M", Name = "Male" },
                new Gender { abbr = "F", Name = "Female" }
                );

            context.Zoos.AddOrUpdate(z => z.Name,
              new Zoo { City = "Little Rock", Name = "Little Rock Zoo", State = "AR" },
              new Zoo { City = "Memphis", Name = "Memphis Zoo", State = "TN" }
              );

            context.Zoos.AddOrUpdate(z => z.Name,
             new Zoo { City = "Little Rock", Name = "Little Rock Zoo", State = "AR" },
             new Zoo { City = "Memphis", Name = "Memphis Zoo", State = "TN" }
             );
        }
    }
}
