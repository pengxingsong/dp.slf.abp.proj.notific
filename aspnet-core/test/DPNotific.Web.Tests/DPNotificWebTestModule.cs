using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DPNotific.EntityFrameworkCore;
using DPNotific.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DPNotific.Web.Tests
{
    [DependsOn(
        typeof(DPNotificWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DPNotificWebTestModule : AbpModule
    {
        public DPNotificWebTestModule(DPNotificEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DPNotificWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DPNotificWebMvcModule).Assembly);
        }
    }
}