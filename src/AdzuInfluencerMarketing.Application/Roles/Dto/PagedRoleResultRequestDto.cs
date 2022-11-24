using Abp.Application.Services.Dto;

namespace AdzuInfluencerMarketing.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

