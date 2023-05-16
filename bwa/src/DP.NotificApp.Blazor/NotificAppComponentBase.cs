using DP.NotificApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DP.NotificApp.Blazor;

public abstract class NotificAppComponentBase : AbpComponentBase
{
    protected NotificAppComponentBase()
    {
        LocalizationResource = typeof(NotificAppResource);
    }
}
