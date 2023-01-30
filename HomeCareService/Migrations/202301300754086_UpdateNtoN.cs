namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNtoN : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customer", "services_ID", "dbo.Services");
            DropIndex("dbo.Customer", new[] { "services_ID" });
            CreateTable(
                "dbo.ServiceCustomers",
                c => new
                    {
                        Service_ID = c.Int(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ID, t.Customer_ID })
                .ForeignKey("dbo.Services", t => t.Service_ID, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Service_ID)
                .Index(t => t.Customer_ID);
            
            DropColumn("dbo.Customer", "services_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "services_ID", c => c.Int());
            DropForeignKey("dbo.ServiceCustomers", "Customer_ID", "dbo.Customer");
            DropForeignKey("dbo.ServiceCustomers", "Service_ID", "dbo.Services");
            DropIndex("dbo.ServiceCustomers", new[] { "Customer_ID" });
            DropIndex("dbo.ServiceCustomers", new[] { "Service_ID" });
            DropTable("dbo.ServiceCustomers");
            CreateIndex("dbo.Customer", "services_ID");
            AddForeignKey("dbo.Customer", "services_ID", "dbo.Services", "ID");
        }
    }
}
