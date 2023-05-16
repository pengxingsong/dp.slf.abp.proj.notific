using System.Threading.Tasks;

namespace DP.NotificApp.Data;

public interface INotificAppDbSchemaMigrator
{
    Task MigrateAsync();
}
