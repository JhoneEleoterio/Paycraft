using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class PayCraftDataContext : DbContext
    {
        public PayCraftDataContext(DbContextOptions<PayCraftDataContext> options) : base(options)
        {}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoriaMapping).Assembly);

            //base.OnModelCreating(modelBuilder);
        }
    }


}
