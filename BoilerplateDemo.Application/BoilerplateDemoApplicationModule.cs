using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace BoilerplateDemo
{
    [DependsOn(typeof(BoilerplateDemoCoreModule), typeof(AbpAutoMapperModule))]
    public class BoilerplateDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
