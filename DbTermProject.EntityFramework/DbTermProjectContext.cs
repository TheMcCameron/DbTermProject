using DbTermProject.Domain.Models;
using System.Data.Entity;

namespace DbTermProject.EntityFramework
{
    /// <summary>
    /// 
    /// TODO: 
    /// 1) Figure out how to name our Db in app.config yet use 
    ///     DesiredDatabaseConnectionString in our call in the constructor.
    ///     
    /// 2) Figure out how to target an instance of SqlServer that we can access from MSSQLServer Manager 2018.
    /// 
    /// 3) Figure out how to Seed() our database.
    /// 
    /// </summary>
    
    public class DbTermProjectContext : DbContext
    {
        public DbTermProjectContext() : base("DbTermProjectDBConnectionString")
        {

        }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bid> Bids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>()
                .Property(b => b.BuyerName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Seller>()
                .Property(s => s.SellerName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Item>()
                .Property(i => i.ItemName)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Item>()
                .Property(i => i.Description)
                .IsRequired()
                .HasMaxLength(1000);
            modelBuilder.Entity<Item>()
                .Property(i => i.InitialPrice)
                .IsRequired();

            modelBuilder.Entity<Bid>()
                .Property(b => b.StartDate)
                .IsRequired();
            modelBuilder.Entity<Bid>()
                .Property(b => b.EndDate)
                .IsRequired();
        }
    }
}
