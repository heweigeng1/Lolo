using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lolo.EntityFrameworkCore
{
    [ConnectionStringName(LoloDbProperties.ConnectionStringName)]
    public class LoloDbContext : AbpDbContext<LoloDbContext>, ILoloDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public LoloDbContext(DbContextOptions<LoloDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureLolo();
        }
    }
}