using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lolo.EntityFrameworkCore
{
    public class LoloHttpApiHostMigrationsDbContext : AbpDbContext<LoloHttpApiHostMigrationsDbContext>
    {
        public LoloHttpApiHostMigrationsDbContext(DbContextOptions<LoloHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureLolo();
        }
    }
}
