using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AdzuInfluencerMarketing.Configuration;
using AdzuInfluencerMarketing.Web;

namespace AdzuInfluencerMarketing.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AdzuInfluencerMarketingDbContextFactory : IDesignTimeDbContextFactory<AdzuInfluencerMarketingDbContext>
    {
        public AdzuInfluencerMarketingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdzuInfluencerMarketingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AdzuInfluencerMarketingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AdzuInfluencerMarketingConsts.ConnectionStringName));

            return new AdzuInfluencerMarketingDbContext(builder.Options);
        }
    }
}
