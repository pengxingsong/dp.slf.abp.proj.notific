using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DPNotific.EntityFrameworkCore
{
    public static class DPNotificDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DPNotificDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DPNotificDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
