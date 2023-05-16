using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DPNotific.Authorization.Roles;
using DPNotific.Authorization.Users;
using DPNotific.MultiTenancy;

namespace DPNotific.EntityFrameworkCore
{
    public class DPNotificDbContext : AbpZeroDbContext<Tenant, Role, User, DPNotificDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DPNotificDbContext(DbContextOptions<DPNotificDbContext> options)
            : base(options)
        {
        }
    }
}
