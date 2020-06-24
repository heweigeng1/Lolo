using MongoDB.Driver;
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
        public IMongoCollection<SMS.SMSTemplate> SMSTemplates => Collection<SMS.SMSTemplate>();
        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureLolo();
        }
    }
}