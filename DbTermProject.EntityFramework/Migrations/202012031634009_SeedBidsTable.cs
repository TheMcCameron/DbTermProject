namespace DbTermProject.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBidsTable : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO dbo.Bids " +
                "VALUES ('06/28/2020', '07/20/2020', 9, 13), " +
                "('06/30/2020', '07/22/2020', 10, 14), " +
                "('07/01/2020', '07/23/2020', 10, 15), " +
                "('07/02/2020', '07/24/2020', 11, 16), " +
                "('07/03/2020', '07/25/2020', 12, 17), " +
                "('07/04/2020', '07/26/2020', 13, 18);"
                );
        }
        
        public override void Down()
        {
            Sql(
                "DELETE FROM dbo.Bids"
                );
        }
    }
}
