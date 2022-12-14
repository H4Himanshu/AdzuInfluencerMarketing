using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using AdzuInfluencerMarketing.Authorization.Roles;
using AdzuInfluencerMarketing.Authorization.Users;
using AdzuInfluencerMarketing.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace AdzuInfluencerMarketing.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
