using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Lnice.EntityFramework;

namespace Lnice
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(LniceCoreModule))]
    public class LniceDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<LniceDbContext>(null);
        }
    }
}
