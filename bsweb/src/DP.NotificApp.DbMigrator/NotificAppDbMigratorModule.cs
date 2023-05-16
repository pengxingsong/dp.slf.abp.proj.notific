using DP.NotificApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DP.NotificApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NotificAppEntityFrameworkCoreModule),
    typeof(NotificAppApplicationContractsModule)
    )]
public class NotificAppDbMigratorModule : AbpModule
{

}
