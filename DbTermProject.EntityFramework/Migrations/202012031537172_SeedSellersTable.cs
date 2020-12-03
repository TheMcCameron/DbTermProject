namespace DbTermProject.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSellersTable : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO dbo.Sellers " +
                "VALUES ('Test Seller1'), ('Test Seller2'), ('Test Seller3'), ('Test Seller4'), ('Test Seller5');"
                );
        }
        
        public override void Down()
        {
            Sql(
                "DELETE FROM dbo.Sellers"
                );
        }
    }
}
