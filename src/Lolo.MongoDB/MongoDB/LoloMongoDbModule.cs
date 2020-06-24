using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Lolo.MongoDB
{
    [DependsOn(
        typeof(LoloDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class LoloMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<LoloMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
                options.AddDefaultRepositories();
            });
        }
    }
}
