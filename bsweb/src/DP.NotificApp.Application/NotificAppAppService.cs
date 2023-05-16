using System;
using System.Collections.Generic;
using System.Text;
using DP.NotificApp.Localization;
using Volo.Abp.Application.Services;

namespace DP.NotificApp;

/* Inherit your application services from this class.
 */
public abstract class NotificAppAppService : ApplicationService
{
    protected NotificAppAppService()
    {
        LocalizationResource = typeof(NotificAppResource);
    }
}
