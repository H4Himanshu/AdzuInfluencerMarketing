using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AdzuInfluencerMarketing.EntityFrameworkCore.Seed;

namespace AdzuInfluencerMarketing.EntityFrameworkCore
{
    [DependsOn(
        typeof(AdzuInfluencerMarketingCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AdzuInfluencerMarketingEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AdzuInfluencerMarketingDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AdzuInfluencerMarketingDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AdzuInfluencerMarketingDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdzuInfluencerMarketingEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
