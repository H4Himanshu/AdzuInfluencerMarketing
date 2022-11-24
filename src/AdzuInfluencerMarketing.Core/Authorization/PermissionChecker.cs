using Abp.Authorization;
using AdzuInfluencerMarketing.Authorization.Roles;
using AdzuInfluencerMarketing.Authorization.Users;

namespace AdzuInfluencerMarketing.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
