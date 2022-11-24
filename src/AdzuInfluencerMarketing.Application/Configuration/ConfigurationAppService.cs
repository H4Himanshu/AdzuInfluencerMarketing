using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AdzuInfluencerMarketing.Configuration.Dto;

namespace AdzuInfluencerMarketing.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdzuInfluencerMarketingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
