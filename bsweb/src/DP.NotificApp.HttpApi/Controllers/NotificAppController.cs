using DP.NotificApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DP.NotificApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NotificAppController : AbpControllerBase
{
    protected NotificAppController()
    {
        LocalizationResource = typeof(NotificAppResource);
    }
}
