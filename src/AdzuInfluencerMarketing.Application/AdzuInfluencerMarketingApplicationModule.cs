using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdzuInfluencerMarketing.Authorization;

namespace AdzuInfluencerMarketing
{
    [DependsOn(
        typeof(AdzuInfluencerMarketingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AdzuInfluencerMarketingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AdzuInfluencerMarketingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdzuInfluencerMarketingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
