using Abp.Application.Services;

namespace Lnice
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class LniceAppServiceBase : ApplicationService
    {
        protected LniceAppServiceBase()
        {
            LocalizationSourceName = LniceConsts.LocalizationSourceName;
        }
    }
}