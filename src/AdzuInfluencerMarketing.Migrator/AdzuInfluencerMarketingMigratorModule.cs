using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdzuInfluencerMarketing.Configuration;
using AdzuInfluencerMarketing.EntityFrameworkCore;
using AdzuInfluencerMarketing.Migrator.DependencyInjection;

namespace AdzuInfluencerMarketing.Migrator
{
    [DependsOn(typeof(AdzuInfluencerMarketingEntityFrameworkModule))]
    public class AdzuInfluencerMarketingMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AdzuInfluencerMarketingMigratorModule(AdzuInfluencerMarketingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AdzuInfluencerMarketingMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AdzuInfluencerMarketingConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdzuInfluencerMarketingMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
