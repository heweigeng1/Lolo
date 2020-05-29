using Volo.Abp.Modularity;

namespace Lolo
{
    [DependsOn(
        typeof(LoloDomainSharedModule)
        )]
    public class LoloDomainModule : AbpModule
    {

    }
}
