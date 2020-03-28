using dotnet_foody.Core;
using Microsoft.EntityFrameworkCore;

namespace dotnet_foody.Data
{
    public class DotnetFoodyDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DotnetFoodyDbContext(DbContextOptions<DotnetFoodyDbContext> options)
            : base(options)
        {

        }
    }
}
