namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revert : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Person", newName: "People");
            RenameTable(name: "dbo.Service", newName: "Services");
            RenameTable(name: "dbo.CustomersService", newName: "ServiceCustomers");
            RenameColumn(table: "dbo.ServiceCustomers", name: "CustomerID", newName: "Customer_ID");
            RenameColumn(table: "dbo.ServiceCustomers", name: "ServiceID", newName: "Service_ID");
            RenameIndex(table: "dbo.ServiceCustomers", name: "IX_ServiceID", newName: "IX_Service_ID");
            RenameIndex(table: "dbo.ServiceCustomers", name: "IX_CustomerID", newName: "IX_Customer_ID");
            DropPrimaryKey("dbo.ServiceCustomers");
            AddPrimaryKey("dbo.ServiceCustomers", new[] { "Service_ID", "Customer_ID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ServiceCustomers");
            AddPrimaryKey("dbo.ServiceCustomers", new[] { "CustomerID", "ServiceID" });
            RenameIndex(table: "dbo.ServiceCustomers", name: "IX_Customer_ID", newName: "IX_CustomerID");
            RenameIndex(table: "dbo.ServiceCustomers", name: "IX_Service_ID", newName: "IX_ServiceID");
            RenameColumn(table: "dbo.ServiceCustomers", name: "Service_ID", newName: "ServiceID");
            RenameColumn(table: "dbo.ServiceCustomers", name: "Customer_ID", newName: "CustomerID");
            RenameTable(name: "dbo.ServiceCustomers", newName: "CustomersService");
            RenameTable(name: "dbo.Services", newName: "Service");
            RenameTable(name: "dbo.People", newName: "Person");
        }
    }
}
