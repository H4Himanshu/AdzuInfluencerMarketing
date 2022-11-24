using Abp.Application.Services;
using AdzuInfluencerMarketing.MultiTenancy.Dto;

namespace AdzuInfluencerMarketing.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

