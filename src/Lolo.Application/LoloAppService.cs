using Lolo.Localization;
using Volo.Abp.Application.Services;

namespace Lolo
{
    public abstract class LoloAppService : ApplicationService
    {
        protected LoloAppService()
        {
            LocalizationResource = typeof(LoloResource);
            ObjectMapperContext = typeof(LoloApplicationModule);
        }
    }
}
