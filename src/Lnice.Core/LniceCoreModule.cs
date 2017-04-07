using System.Reflection;
using Abp.Modules;

namespace Lnice
{
    public class LniceCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
