namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedKungFuRanking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pandas", "KungFuRanking", c => c.Int(nullable: false, defaultValue: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pandas", "KungFuRanking");
        }
    }
}
