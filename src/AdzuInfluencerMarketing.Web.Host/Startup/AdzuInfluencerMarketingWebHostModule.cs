using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdzuInfluencerMarketing.Configuration;

namespace AdzuInfluencerMarketing.Web.Host.Startup
{
    [DependsOn(
       typeof(AdzuInfluencerMarketingWebCoreModule))]
    public class AdzuInfluencerMarketingWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdzuInfluencerMarketingWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdzuInfluencerMarketingWebHostModule).GetAssembly());
        }
    }
}
