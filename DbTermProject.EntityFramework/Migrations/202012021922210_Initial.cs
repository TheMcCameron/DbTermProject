namespace DbTermProject.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Buyer_Id = c.Int(),
                        Item_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyerName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 1000),
                        InitialPrice = c.Single(nullable: false),
                        SoldPrice = c.Single(nullable: false),
                        Seller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sellers", t => t.Seller_Id)
                .Index(t => t.Seller_Id);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SellerName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "Seller_Id", "dbo.Sellers");
            DropForeignKey("dbo.Bids", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Items", new[] { "Seller_Id" });
            DropIndex("dbo.Bids", new[] { "Item_Id" });
            DropIndex("dbo.Bids", new[] { "Buyer_Id" });
            DropTable("dbo.Sellers");
            DropTable("dbo.Items");
            DropTable("dbo.Buyers");
            DropTable("dbo.Bids");
        }
    }
}
