using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AdzuInfluencerMarketing.Controllers
{
    public abstract class AdzuInfluencerMarketingControllerBase: AbpController
    {
        protected AdzuInfluencerMarketingControllerBase()
        {
            LocalizationSourceName = AdzuInfluencerMarketingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
