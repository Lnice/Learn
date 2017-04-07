using Abp.Web.Mvc.Views;

namespace Lnice.Web.Views
{
    public abstract class LniceWebViewPageBase : LniceWebViewPageBase<dynamic>
    {

    }

    public abstract class LniceWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LniceWebViewPageBase()
        {
            LocalizationSourceName = LniceConsts.LocalizationSourceName;
        }
    }
}