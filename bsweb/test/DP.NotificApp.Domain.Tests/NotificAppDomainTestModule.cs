using DP.NotificApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DP.NotificApp;

[DependsOn(
    typeof(NotificAppEntityFrameworkCoreTestModule)
    )]
public class NotificAppDomainTestModule : AbpModule
{

}
