namespace DbTermProject.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedItemsTable : DbMigration
    {
        //TODO: Up()
        public override void Up()
        {
            Sql(
                "INSERT INTO dbo.Items " +
                "VALUES ('Item1', 'Item1 Description', 10.00, 25.00, 6), " +
                "('Item2', 'Item2 Description', 15.00, 39.00, 7), " +
                "('Item3', 'Item3 Description', 300.00, 450.00, 8), " +
                "('Item4', 'Item4 Description', 20.00, 50.00, 8), " +
                "('Item5', 'Item5 Description', 30.00, 120.00, 9), " +
                "('Item6', 'Item6 Description', 300.00, 390.30, 10);"
                );
        }
        
        public override void Down()
        {
            Sql(
                "DELETE FROM dbo.Items"
                );
        }
    }
}
