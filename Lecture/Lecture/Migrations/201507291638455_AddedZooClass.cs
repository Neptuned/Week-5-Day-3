namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedZooClass : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pandas", new[] { "Gender_Id" });
            CreateTable(
                "dbo.Zoos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pandas", "Zoo_Id", c => c.Int());
            AlterColumn("dbo.Pandas", "Gender_id", c => c.Int());
            CreateIndex("dbo.Pandas", "Gender_id");
            CreateIndex("dbo.Pandas", "Zoo_Id");
            AddForeignKey("dbo.Pandas", "Zoo_Id", "dbo.Zoos", "Id");
            DropColumn("dbo.Pandas", "ZooName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pandas", "ZooName", c => c.String(nullable: false, maxLength: 1000));
            DropForeignKey("dbo.Pandas", "Zoo_Id", "dbo.Zoos");
            DropIndex("dbo.Pandas", new[] { "Zoo_Id" });
            DropIndex("dbo.Pandas", new[] { "Gender_id" });
            AlterColumn("dbo.Pandas", "Gender_id", c => c.Int(nullable: false));
            DropColumn("dbo.Pandas", "Zoo_Id");
            DropTable("dbo.Zoos");
            CreateIndex("dbo.Pandas", "Gender_Id");
        }
    }
}
