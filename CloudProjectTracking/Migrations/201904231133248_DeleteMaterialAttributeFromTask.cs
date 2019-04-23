namespace CloudProjectTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMaterialAttributeFromTask : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "Material");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Material", c => c.String());
        }
    }
}
