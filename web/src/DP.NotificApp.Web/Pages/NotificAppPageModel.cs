using DP.NotificApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DP.NotificApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NotificAppPageModel : AbpPageModel
{
    protected NotificAppPageModel()
    {
        LocalizationResourceType = typeof(NotificAppResource);
    }
}
