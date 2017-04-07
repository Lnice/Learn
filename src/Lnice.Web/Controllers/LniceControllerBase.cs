using Abp.Web.Mvc.Controllers;

namespace Lnice.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class LniceControllerBase : AbpController
    {
        protected LniceControllerBase()
        {
            LocalizationSourceName = LniceConsts.LocalizationSourceName;
        }
    }
}