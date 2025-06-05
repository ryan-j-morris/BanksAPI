using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Banks.SQL
{
    public class BanksContext : DbContext
    {
        public BanksContext(DbContextOptions<BanksContext> options) : base(options) { }

        public DbSet<Bank.Bank> Banks { get; set; }
        public DbSet<Bank.Branch> Branches { get; set; }
        public DbSet<Product.Product> Products { get; set; }
        public DbSet<Product.Issue> Issues { get; set; }
    }

    public class BanksContextFactory : IDesignTimeDbContextFactory<BanksContext>
    {
        public BanksContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Local");

            var optionsBuilder = new DbContextOptionsBuilder<BanksContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BanksContext(optionsBuilder.Options);
        }
    }
}
