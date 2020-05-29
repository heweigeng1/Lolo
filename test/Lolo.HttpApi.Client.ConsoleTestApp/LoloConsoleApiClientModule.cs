using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Lolo
{
    [DependsOn(
        typeof(LoloHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LoloConsoleApiClientModule : AbpModule
    {
        
    }
}
