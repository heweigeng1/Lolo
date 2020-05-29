using Lolo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lolo
{
    public abstract class LoloController : AbpController
    {
        protected LoloController()
        {
            LocalizationResource = typeof(LoloResource);
        }
    }
}
