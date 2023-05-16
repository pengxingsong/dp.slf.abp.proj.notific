using Abp.Authorization;
using DPNotific.Authorization.Roles;
using DPNotific.Authorization.Users;

namespace DPNotific.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
