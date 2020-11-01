using Microsoft.EntityFrameworkCore;
using Skinet.API.Entities;

namespace Skinet.API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
