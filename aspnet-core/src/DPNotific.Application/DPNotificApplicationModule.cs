using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DPNotific.Authorization;

namespace DPNotific
{
    [DependsOn(
        typeof(DPNotificCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DPNotificApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DPNotificAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DPNotificApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
