using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Lnice
{
    [DependsOn(typeof(AbpWebApiModule), typeof(LniceApplicationModule))]
    public class LniceWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(LniceApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
