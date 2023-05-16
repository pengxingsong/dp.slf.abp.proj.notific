using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DP.NotificApp;

[Dependency(ReplaceServices = true)]
public class NotificAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NotificApp";
}
