using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Lolo
{
    [DependsOn(
        typeof(LoloDomainModule),
        typeof(LoloApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LoloApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LoloApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LoloApplicationModule>(validate: true);
            });
        }
    }
}
