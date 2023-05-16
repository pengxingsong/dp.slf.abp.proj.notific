using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DPNotific.Configuration;

namespace DPNotific.Web.Host.Startup
{
    [DependsOn(
       typeof(DPNotificWebCoreModule))]
    public class DPNotificWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DPNotificWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DPNotificWebHostModule).GetAssembly());
        }
    }
}
