using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DP.NotificApp;

[DependsOn(typeof(AbpAutofacModule))]
public class NotificAppModule : AbpModule
{
}
