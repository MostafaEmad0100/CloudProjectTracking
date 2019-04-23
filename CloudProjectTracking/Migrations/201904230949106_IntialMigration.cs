namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drawings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Drwaing_Name = c.String(),
                        Consultant_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.Consultant_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Consultant_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Single(nullable: false),
                        Material = c.String(),
                        Start_Date = c.DateTime(),
                        End_Date = c.DateTime(),
                        Contractor_Id = c.Int(),
                        Project_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order_Date = c.DateTime(),
                        Cost = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Contractor_Id = c.Int(),
                        Material_Id = c.Int(),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Project_Name = c.String(),
                        Consultant_Id = c.Int(),
                        Contractor_Id = c.Int(),
                        Project_Manger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.Consultant_Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .ForeignKey("dbo.Project_Manager", t => t.Project_Manger_Id)
                .Index(t => t.Consultant_Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Project_Manger_Id);
            
            CreateTable(
                "dbo.Project_Manager",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectManger_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RFIs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Consultant_Id = c.Int(),
                        Contractor_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.Consultant_Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Consultant_Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.Submitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Consultant_Id = c.Int(),
                        Contractor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.Consultant_Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .Index(t => t.Consultant_Id)
                .Index(t => t.Contractor_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Consultant_Id = c.Int(),
                        Contractor_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.Consultant_Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Consultant_Id)
                .Index(t => t.Contractor_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Task_Notification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplierMaterials",
                c => new
                    {
                        Supplier_Id = c.Int(nullable: false),
                        Material_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_Id, t.Material_Id })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id, cascadeDelete: true)
                .ForeignKey("dbo.Materials", t => t.Material_Id, cascadeDelete: true)
                .Index(t => t.Supplier_Id)
                .Index(t => t.Material_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Reports", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Reports", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.Reports", "Consultant_Id", "dbo.Consultants");
            DropForeignKey("dbo.Tasks", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Drawings", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Tasks", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.Submitals", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.Submitals", "Consultant_Id", "dbo.Consultants");
            DropForeignKey("dbo.RFIs", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.RFIs", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.RFIs", "Consultant_Id", "dbo.Consultants");
            DropForeignKey("dbo.Projects", "Project_Manger_Id", "dbo.Project_Manager");
            DropForeignKey("dbo.Projects", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.Projects", "Consultant_Id", "dbo.Consultants");
            DropForeignKey("dbo.Orders", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierMaterials", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.SupplierMaterials", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Orders", "Contractor_Id", "dbo.Contractors");
            DropForeignKey("dbo.Drawings", "Consultant_Id", "dbo.Consultants");
            DropIndex("dbo.SupplierMaterials", new[] { "Material_Id" });
            DropIndex("dbo.SupplierMaterials", new[] { "Supplier_Id" });
            DropIndex("dbo.Reports", new[] { "Task_Id" });
            DropIndex("dbo.Reports", new[] { "Contractor_Id" });
            DropIndex("dbo.Reports", new[] { "Consultant_Id" });
            DropIndex("dbo.Submitals", new[] { "Contractor_Id" });
            DropIndex("dbo.Submitals", new[] { "Consultant_Id" });
            DropIndex("dbo.RFIs", new[] { "Task_Id" });
            DropIndex("dbo.RFIs", new[] { "Contractor_Id" });
            DropIndex("dbo.RFIs", new[] { "Consultant_Id" });
            DropIndex("dbo.Projects", new[] { "Project_Manger_Id" });
            DropIndex("dbo.Projects", new[] { "Contractor_Id" });
            DropIndex("dbo.Projects", new[] { "Consultant_Id" });
            DropIndex("dbo.Orders", new[] { "Supplier_Id" });
            DropIndex("dbo.Orders", new[] { "Material_Id" });
            DropIndex("dbo.Orders", new[] { "Contractor_Id" });
            DropIndex("dbo.Tasks", new[] { "Status_Id" });
            DropIndex("dbo.Tasks", new[] { "Project_Id" });
            DropIndex("dbo.Tasks", new[] { "Contractor_Id" });
            DropIndex("dbo.Drawings", new[] { "Task_Id" });
            DropIndex("dbo.Drawings", new[] { "Consultant_Id" });
            DropTable("dbo.SupplierMaterials");
            DropTable("dbo.Task_Notification");
            DropTable("dbo.Status");
            DropTable("dbo.Reports");
            DropTable("dbo.Submitals");
            DropTable("dbo.RFIs");
            DropTable("dbo.Project_Manager");
            DropTable("dbo.Projects");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Materials");
            DropTable("dbo.Orders");
            DropTable("dbo.Contractors");
            DropTable("dbo.Tasks");
            DropTable("dbo.Drawings");
            DropTable("dbo.Consultants");
        }
    }
}
