namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        abbr = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Pandas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender_Id = c.Int(nullable: false),
                        ZooName = c.String(nullable: false, maxLength: 1000),
                        Weight = c.Int(),
                        personality = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.Gender_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pandas", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Pandas", new[] { "Gender_Id" });
            DropTable("dbo.Pandas");
            DropTable("dbo.Genders");
        }
    }
}
