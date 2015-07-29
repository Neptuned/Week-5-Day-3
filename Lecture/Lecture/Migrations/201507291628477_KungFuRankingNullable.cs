namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KungFuRankingNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pandas", "KungFuRanking", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pandas", "KungFuRanking", c => c.Int(nullable: false));
        }
    }
}
