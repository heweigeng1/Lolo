using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Lolo
{
    [DependsOn(
        typeof(LoloApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class LoloHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Lolo";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(LoloApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
