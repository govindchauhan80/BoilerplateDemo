using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BoilerplateDemo.EntityFramework;

namespace BoilerplateDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BoilerplateDemoCoreModule))]
    public class BoilerplateDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
