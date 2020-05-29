using Volo.Abp.Modularity;

namespace Lolo
{
    [DependsOn(
        typeof(LoloApplicationModule),
        typeof(LoloDomainTestModule)
        )]
    public class LoloApplicationTestModule : AbpModule
    {

    }
}
