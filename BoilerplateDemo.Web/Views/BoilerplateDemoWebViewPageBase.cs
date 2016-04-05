using Abp.Web.Mvc.Views;

namespace BoilerplateDemo.Web.Views
{
    public abstract class BoilerplateDemoWebViewPageBase : BoilerplateDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerplateDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerplateDemoWebViewPageBase()
        {
            LocalizationSourceName = BoilerplateDemoConsts.LocalizationSourceName;
        }
    }
}