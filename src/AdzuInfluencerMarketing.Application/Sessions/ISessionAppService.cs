using System.Threading.Tasks;
using Abp.Application.Services;
using AdzuInfluencerMarketing.Sessions.Dto;

namespace AdzuInfluencerMarketing.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
