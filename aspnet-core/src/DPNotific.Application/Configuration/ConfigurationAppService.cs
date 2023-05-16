﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DPNotific.Configuration.Dto;

namespace DPNotific.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DPNotificAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
