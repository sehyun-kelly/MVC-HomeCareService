namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerService : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Person");
            RenameTable(name: "dbo.Services", newName: "Service");
            RenameTable(name: "dbo.ServiceCustomers", newName: "CustomersService");
            RenameColumn(table: "dbo.CustomersService", name: "Service_ID", newName: "ServiceID");
            RenameColumn(table: "dbo.CustomersService", name: "Customer_ID", newName: "CustomerID");
            RenameIndex(table: "dbo.CustomersService", name: "IX_Customer_ID", newName: "IX_CustomerID");
            RenameIndex(table: "dbo.CustomersService", name: "IX_Service_ID", newName: "IX_ServiceID");
            DropPrimaryKey("dbo.CustomersService");
            AddPrimaryKey("dbo.CustomersService", new[] { "CustomerID", "ServiceID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CustomersService");
            AddPrimaryKey("dbo.CustomersService", new[] { "Service_ID", "Customer_ID" });
            RenameIndex(table: "dbo.CustomersService", name: "IX_ServiceID", newName: "IX_Service_ID");
            RenameIndex(table: "dbo.CustomersService", name: "IX_CustomerID", newName: "IX_Customer_ID");
            RenameColumn(table: "dbo.CustomersService", name: "CustomerID", newName: "Customer_ID");
            RenameColumn(table: "dbo.CustomersService", name: "ServiceID", newName: "Service_ID");
            RenameTable(name: "dbo.CustomersService", newName: "ServiceCustomers");
            RenameTable(name: "dbo.Service", newName: "Services");
            RenameTable(name: "dbo.Person", newName: "People");
        }
    }
}
