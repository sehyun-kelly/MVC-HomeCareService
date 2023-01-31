namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuildTest : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ServiceCustomers", newName: "CustomerService");
            DropPrimaryKey("dbo.CustomerService");
            AddPrimaryKey("dbo.CustomerService", new[] { "Customer_ID", "Service_ID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CustomerService");
            AddPrimaryKey("dbo.CustomerService", new[] { "Service_ID", "Customer_ID" });
            RenameTable(name: "dbo.CustomerService", newName: "ServiceCustomers");
        }
    }
}
