using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lolo.MongoDB
{
    [ConnectionStringName(LoloDbProperties.ConnectionStringName)]
    public interface ILoloMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
