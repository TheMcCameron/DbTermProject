namespace DbTermProject.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBuyersTable : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO dbo.Buyers " +
                "VALUES ('Test Buyer1'), ('Test Buyer2'), ('Test Buyer3'), ('Test Buyer4'), ('Test Buyer5');"
                );
        }
        
        public override void Down()
        {
            Sql(
               "DELETE FROM dbo.Buyers;"
               );
        }
    }
}
