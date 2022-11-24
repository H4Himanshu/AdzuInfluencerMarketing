using System.Threading.Tasks;
using Abp.Application.Services;
using AdzuInfluencerMarketing.Authorization.Accounts.Dto;

namespace AdzuInfluencerMarketing.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
