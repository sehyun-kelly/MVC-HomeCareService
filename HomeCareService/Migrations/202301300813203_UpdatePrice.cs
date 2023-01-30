namespace HomeCareService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Price");
        }
    }
}
