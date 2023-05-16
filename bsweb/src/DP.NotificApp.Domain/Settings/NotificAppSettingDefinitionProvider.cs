using Volo.Abp.Settings;

namespace DP.NotificApp.Settings;

public class NotificAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NotificAppSettings.MySetting1));
    }
}
