namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTasksMaterialTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks_Matrial",
                c => new
                    {
                        FK_Task = c.Int(nullable: false),
                        FK_Material = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FK_Task, t.FK_Material })
                .ForeignKey("dbo.Materials", t => t.FK_Material, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.FK_Task, cascadeDelete: true)
                .Index(t => t.FK_Material)
                .Index(t => t.FK_Task);

            
                
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialTasks", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.MaterialTasks", "Material_Id", "dbo.Materials");
            DropIndex("dbo.MaterialTasks", new[] { "Task_Id" });
            DropIndex("dbo.MaterialTasks", new[] { "Material_Id" });
            DropTable("dbo.MaterialTasks");
            DropTable("dbo.Tasks_Matrial");
        }
    }
}
