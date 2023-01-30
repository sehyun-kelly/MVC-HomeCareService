namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        services_ID = c.Int(),
                        Payment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .ForeignKey("dbo.Services", t => t.services_ID)
                .Index(t => t.ID)
                .Index(t => t.services_ID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        service_ID = c.Int(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .ForeignKey("dbo.Services", t => t.service_ID)
                .Index(t => t.ID)
                .Index(t => t.service_ID);
            
            DropTable("dbo.Clients");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Employee", "service_ID", "dbo.Services");
            DropForeignKey("dbo.Employee", "ID", "dbo.People");
            DropForeignKey("dbo.Customer", "services_ID", "dbo.Services");
            DropForeignKey("dbo.Customer", "ID", "dbo.People");
            DropIndex("dbo.Employee", new[] { "service_ID" });
            DropIndex("dbo.Employee", new[] { "ID" });
            DropIndex("dbo.Customer", new[] { "services_ID" });
            DropIndex("dbo.Customer", new[] { "ID" });
            DropTable("dbo.Employee");
            DropTable("dbo.Customer");
            DropTable("dbo.Services");
            DropTable("dbo.People");
        }
    }
}
