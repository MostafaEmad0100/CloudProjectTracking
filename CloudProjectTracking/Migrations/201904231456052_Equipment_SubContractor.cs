namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Equipment_SubContractor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sub_Contractor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contractor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contractors", t => t.Contractor_Id)
                .Index(t => t.Contractor_Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Task_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Sub_Contractor", "Contractor_Id", "dbo.Contractors");
            DropIndex("dbo.Equipments", new[] { "Task_Id" });
            DropIndex("dbo.Sub_Contractor", new[] { "Contractor_Id" });
            DropTable("dbo.Equipments");
            DropTable("dbo.Sub_Contractor");
        }
    }
}
