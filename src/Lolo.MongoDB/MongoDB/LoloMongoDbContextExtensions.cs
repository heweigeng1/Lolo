using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lolo.MongoDB
{
    public static class LoloMongoDbContextExtensions
    {
        public static void ConfigureLolo(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new LoloMongoModelBuilderConfigurationOptions(
                LoloDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}