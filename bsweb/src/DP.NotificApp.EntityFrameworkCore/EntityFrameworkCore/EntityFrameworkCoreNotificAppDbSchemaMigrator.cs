using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DP.NotificApp.Data;
using Volo.Abp.DependencyInjection;

namespace DP.NotificApp.EntityFrameworkCore;

public class EntityFrameworkCoreNotificAppDbSchemaMigrator
    : INotificAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNotificAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NotificAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NotificAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
