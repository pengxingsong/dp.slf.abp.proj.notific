using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DP.NotificApp.Data;

/* This is used if database provider does't define
 * INotificAppDbSchemaMigrator implementation.
 */
public class NullNotificAppDbSchemaMigrator : INotificAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
