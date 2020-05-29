using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lolo.EntityFrameworkCore
{
    public class LoloModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public LoloModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}