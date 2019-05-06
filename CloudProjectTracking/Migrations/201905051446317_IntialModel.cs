namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.Subtasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BudgetCostWorkSchudling_BCWS = c.Double(nullable: false),
                        ActualCostofWorkPerformed_ACWP = c.Double(nullable: false),
                        BudgetCostofWorkPerformed_BCWP = c.Double(nullable: false),
                        Description = c.String(),
                        Start_Date = c.DateTime(),
                        End_Date = c.DateTime(),
                        Actual_Start_Date = c.DateTime(),
                        Actual_End_Date = c.DateTime(),
                        Estimated_Duration = c.Double(nullable: false),
                        PercentageOfCompleteion = c.Double(nullable: false),
                        SchudulingIndex_SI = c.Double(nullable: false),
                        CostIndex_CI = c.Double(nullable: false),
                        ExpectedFinalDuration = c.Double(nullable: false),
                        ExpectedFinalCost = c.Double(nullable: false),
                        Contractor_Id = c.Int(),
                        Project_Id = c.Int(),
                        Status_Id = c.Int(),
                        Task_Id = c.Int(),
                        Consultant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.Task_Id)
                .Index(t => t.Consultant_Id);
            
            AddColumn("dbo.Drawings", "Subtasks_Id", c => c.Int());
            AddColumn("dbo.Materials", "Subtasks_Id", c => c.Int());
            AddColumn("dbo.RFIs", "Subtasks_Id", c => c.Int());
            AddColumn("dbo.Equipments", "Subtasks_Id", c => c.Int());
            AddColumn("dbo.Reports", "Subtasks_Id", c => c.Int());
            AddColumn("dbo.Task_Documents", "Subtasks_Id", c => c.Int());
            CreateIndex("dbo.Drawings", "Subtasks_Id");
            CreateIndex("dbo.Materials", "Subtasks_Id");
            CreateIndex("dbo.RFIs", "Subtasks_Id");
            CreateIndex("dbo.Equipments", "Subtasks_Id");
            CreateIndex("dbo.Reports", "Subtasks_Id");
            CreateIndex("dbo.Task_Documents", "Subtasks_Id");
            AddForeignKey("dbo.Materials", "Subtasks_Id", "dbo.Subtasks", "Id");
            AddForeignKey("dbo.Drawings", "Subtasks_Id", "dbo.Subtasks", "Id");
            AddForeignKey("dbo.Equipments", "Subtasks_Id", "dbo.Subtasks", "Id");
            AddForeignKey("dbo.Reports", "Subtasks_Id", "dbo.Subtasks", "Id");
            AddForeignKey("dbo.RFIs", "Subtasks_Id", "dbo.Subtasks", "Id");
            AddForeignKey("dbo.Task_Documents", "Subtasks_Id", "dbo.Subtasks", "Id");
         
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Consultant_Id", c => c.Int());
            AddColumn("dbo.Tasks", "Task_Id", c => c.Int());
            AddColumn("dbo.Tasks", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Task_Documents", "Subtasks_Id", "dbo.Subtasks");
            DropForeignKey("dbo.RFIs", "Subtasks_Id", "dbo.Subtasks");
            DropForeignKey("dbo.Reports", "Subtasks_Id", "dbo.Subtasks");
            DropForeignKey("dbo.Equipments", "Subtasks_Id", "dbo.Subtasks");
            DropForeignKey("dbo.Drawings", "Subtasks_Id", "dbo.Subtasks");
            DropForeignKey("dbo.Materials", "Subtasks_Id", "dbo.Subtasks");
            DropIndex("dbo.Task_Documents", new[] { "Subtasks_Id" });
            DropIndex("dbo.Subtasks", new[] { "Consultant_Id" });
            DropIndex("dbo.Subtasks", new[] { "Task_Id" });
            DropIndex("dbo.Subtasks", new[] { "Status_Id" });
            DropIndex("dbo.Subtasks", new[] { "Project_Id" });
            DropIndex("dbo.Subtasks", new[] { "Contractor_Id" });
            DropIndex("dbo.Reports", new[] { "Subtasks_Id" });
            DropIndex("dbo.Equipments", new[] { "Subtasks_Id" });
            DropIndex("dbo.RFIs", new[] { "Subtasks_Id" });
            DropIndex("dbo.Materials", new[] { "Subtasks_Id" });
            DropIndex("dbo.Drawings", new[] { "Subtasks_Id" });
            DropColumn("dbo.Task_Documents", "Subtasks_Id");
            DropColumn("dbo.Reports", "Subtasks_Id");
            DropColumn("dbo.Equipments", "Subtasks_Id");
            DropColumn("dbo.RFIs", "Subtasks_Id");
            DropColumn("dbo.Materials", "Subtasks_Id");
            DropColumn("dbo.Drawings", "Subtasks_Id");
            DropTable("dbo.Subtasks");
            CreateIndex("dbo.Tasks", "Consultant_Id");
            CreateIndex("dbo.Tasks", "Task_Id");
            AddForeignKey("dbo.Task_Documents", "Task_Id", "dbo.Tasks", "Id");
            AddForeignKey("dbo.RFIs", "Task_Id", "dbo.Tasks", "Id");
            AddForeignKey("dbo.Reports", "Task_Id", "dbo.Tasks", "Id");
            AddForeignKey("dbo.Equipments", "Task_Id", "dbo.Tasks", "Id");
            AddForeignKey("dbo.Drawings", "Task_Id", "dbo.Tasks", "Id");
        }
    }
}
