namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Actual_Start_Date", c => c.DateTime());
            AddColumn("dbo.Tasks", "Actual_End_Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Actual_End_Date");
            DropColumn("dbo.Tasks", "Actual_Start_Date");
        }
    }
}
