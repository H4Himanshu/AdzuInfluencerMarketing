using Abp.MultiTenancy;
using AdzuInfluencerMarketing.Authorization.Users;

namespace AdzuInfluencerMarketing.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
