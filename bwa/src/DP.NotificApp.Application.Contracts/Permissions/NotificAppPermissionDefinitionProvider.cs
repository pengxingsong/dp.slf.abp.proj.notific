using DP.NotificApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DP.NotificApp.Permissions;

public class NotificAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NotificAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NotificAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NotificAppResource>(name);
    }
}
