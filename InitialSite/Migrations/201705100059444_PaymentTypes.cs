namespace InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentTypes", "PaymentTypeName", c => c.String(nullable: false));
            DropColumn("dbo.PaymentTypes", "PaymentTypeNameType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PaymentTypes", "PaymentTypeNameType", c => c.String(nullable: false));
            DropColumn("dbo.PaymentTypes", "PaymentTypeName");
        }
    }
}
