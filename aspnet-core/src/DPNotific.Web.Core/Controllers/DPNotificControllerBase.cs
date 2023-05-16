using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DPNotific.Controllers
{
    public abstract class DPNotificControllerBase: AbpController
    {
        protected DPNotificControllerBase()
        {
            LocalizationSourceName = DPNotificConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
