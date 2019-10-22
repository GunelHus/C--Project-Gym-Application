namespace GymApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entryquantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "PackageEntryQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "PackageEntryQuantity");
        }
    }
}
