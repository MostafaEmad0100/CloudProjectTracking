namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Task : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Duration", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Duration");
        }
    }
}
