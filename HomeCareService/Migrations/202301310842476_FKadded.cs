namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "services_ID", "dbo.Services");
            DropIndex("dbo.Employee", new[] { "services_ID" });
            AlterColumn("dbo.Employee", "services_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "services_ID");
            AddForeignKey("dbo.Employee", "services_ID", "dbo.Services", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "services_ID", "dbo.Services");
            DropIndex("dbo.Employee", new[] { "services_ID" });
            AlterColumn("dbo.Employee", "services_ID", c => c.Int());
            CreateIndex("dbo.Employee", "services_ID");
            AddForeignKey("dbo.Employee", "services_ID", "dbo.Services", "ID");
        }
    }
}
