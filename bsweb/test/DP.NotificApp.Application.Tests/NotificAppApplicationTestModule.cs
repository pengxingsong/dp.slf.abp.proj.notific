using Volo.Abp.Modularity;

namespace DP.NotificApp;

[DependsOn(
    typeof(NotificAppApplicationModule),
    typeof(NotificAppDomainTestModule)
    )]
public class NotificAppApplicationTestModule : AbpModule
{

}
