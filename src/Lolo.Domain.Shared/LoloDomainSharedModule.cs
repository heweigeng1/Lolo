using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Lolo.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Lolo
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LoloDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LoloDomainSharedModule>("Lolo");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<LoloResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Lolo");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Lolo", typeof(LoloResource));
            });
        }
    }
}
