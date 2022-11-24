using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using AdzuInfluencerMarketing.Authorization.Roles;
using AdzuInfluencerMarketing.Authorization.Users;
using AdzuInfluencerMarketing.Configuration;
using AdzuInfluencerMarketing.Localization;
using AdzuInfluencerMarketing.MultiTenancy;
using AdzuInfluencerMarketing.Timing;

namespace AdzuInfluencerMarketing
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AdzuInfluencerMarketingCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AdzuInfluencerMarketingLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AdzuInfluencerMarketingConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdzuInfluencerMarketingCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
