using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DP.NotificApp.Web;

[Dependency(ReplaceServices = true)]
public class NotificAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NotificApp";
}
