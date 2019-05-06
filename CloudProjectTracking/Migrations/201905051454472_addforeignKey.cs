namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addforeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subtasks", "FK_Task", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subtasks", "FK_Task");
        }
    }
}
