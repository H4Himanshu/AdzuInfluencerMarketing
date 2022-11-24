using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AdzuInfluencerMarketing.EntityFrameworkCore
{
    public static class AdzuInfluencerMarketingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AdzuInfluencerMarketingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AdzuInfluencerMarketingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
