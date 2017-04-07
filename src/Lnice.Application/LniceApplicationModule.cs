using System.Reflection;
using Abp.Modules;

namespace Lnice
{
    [DependsOn(typeof(LniceCoreModule))]
    public class LniceApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
