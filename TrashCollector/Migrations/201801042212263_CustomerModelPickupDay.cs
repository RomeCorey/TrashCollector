namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModelPickupDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickupDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickupDay");
        }
    }
}
