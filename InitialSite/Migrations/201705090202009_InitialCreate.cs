namespace InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderCarts",
                c => new
                    {
                        OrderCartId = c.Int(nullable: false, identity: true),
                        OrderCartTotal = c.Double(nullable: false),
                        Customer_CustomerId = c.Int(),
                        PaymentType_PaymentTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderCartId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_PaymentTypeId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.PaymentType_PaymentTypeId);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        PaymentTypeId = c.Int(nullable: false, identity: true),
                        PaymentTypeNameType = c.String(nullable: false),
                        AccountNumber = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.PaymentTypeId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductPrice = c.Double(nullable: false),
                        Customer_CustomerId = c.Int(),
                        ProductType_ProductTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_ProductTypeId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.ProductType_ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductLabel = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.ProductOrderCarts",
                c => new
                    {
                        Product_ProductId = c.Int(nullable: false),
                        OrderCart_OrderCartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductId, t.OrderCart_OrderCartId })
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.OrderCarts", t => t.OrderCart_OrderCartId, cascadeDelete: true)
                .Index(t => t.Product_ProductId)
                .Index(t => t.OrderCart_OrderCartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductOrderCarts", "OrderCart_OrderCartId", "dbo.OrderCarts");
            DropForeignKey("dbo.ProductOrderCarts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderCarts", "PaymentType_PaymentTypeId", "dbo.PaymentTypes");
            DropForeignKey("dbo.PaymentTypes", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderCarts", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.ProductOrderCarts", new[] { "OrderCart_OrderCartId" });
            DropIndex("dbo.ProductOrderCarts", new[] { "Product_ProductId" });
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            DropIndex("dbo.Products", new[] { "Customer_CustomerId" });
            DropIndex("dbo.PaymentTypes", new[] { "Customer_CustomerId" });
            DropIndex("dbo.OrderCarts", new[] { "PaymentType_PaymentTypeId" });
            DropIndex("dbo.OrderCarts", new[] { "Customer_CustomerId" });
            DropTable("dbo.ProductOrderCarts");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.OrderCarts");
            DropTable("dbo.Customers");
        }
    }
}
