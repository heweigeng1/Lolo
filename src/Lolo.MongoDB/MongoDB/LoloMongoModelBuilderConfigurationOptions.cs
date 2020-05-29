using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Lolo.MongoDB
{
    public class LoloMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public LoloMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}