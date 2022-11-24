using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AdzuInfluencerMarketing.Authorization.Roles;
using AdzuInfluencerMarketing.Authorization.Users;
using AdzuInfluencerMarketing.MultiTenancy;

namespace AdzuInfluencerMarketing.EntityFrameworkCore
{
    public class AdzuInfluencerMarketingDbContext : AbpZeroDbContext<Tenant, Role, User, AdzuInfluencerMarketingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdzuInfluencerMarketingDbContext(DbContextOptions<AdzuInfluencerMarketingDbContext> options)
            : base(options)
        {
        }
    }
}
