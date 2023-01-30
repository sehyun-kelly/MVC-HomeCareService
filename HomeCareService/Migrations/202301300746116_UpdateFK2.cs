namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFK2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "service_ID", newName: "services_ID");
            RenameIndex(table: "dbo.Employee", name: "IX_service_ID", newName: "IX_services_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employee", name: "IX_services_ID", newName: "IX_service_ID");
            RenameColumn(table: "dbo.Employee", name: "services_ID", newName: "service_ID");
        }
    }
}
