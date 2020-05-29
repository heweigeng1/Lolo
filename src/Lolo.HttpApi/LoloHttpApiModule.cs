using Localization.Resources.AbpUi;
using Lolo.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lolo
{
    [DependsOn(
        typeof(LoloApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LoloHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LoloHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<LoloResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
