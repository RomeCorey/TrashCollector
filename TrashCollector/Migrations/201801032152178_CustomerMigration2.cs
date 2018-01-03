namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "StreetName", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "AddressId");
            DropTable("dbo.Addresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Zipcode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "AddressId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "StreetName");
        }
    }
}
