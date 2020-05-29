using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lolo.MongoDB
{
    [ConnectionStringName(LoloDbProperties.ConnectionStringName)]
    public class LoloMongoDbContext : AbpMongoDbContext, ILoloMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureLolo();
        }
    }
}