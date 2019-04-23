namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipment_documentfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Task_Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Document_Name = c.String(),
                        Data = c.Binary(),
                        FileName = c.String(),
                        ContentType = c.String(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Task_Id);
            
            AddColumn("dbo.Tasks", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task_Documents", "Task_Id", "dbo.Tasks");
            DropIndex("dbo.Task_Documents", new[] { "Task_Id" });
            DropColumn("dbo.Tasks", "Description");
            DropTable("dbo.Task_Documents");
        }
    }
}
