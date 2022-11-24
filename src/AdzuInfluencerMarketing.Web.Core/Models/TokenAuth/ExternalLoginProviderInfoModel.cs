using Abp.AutoMapper;
using AdzuInfluencerMarketing.Authentication.External;

namespace AdzuInfluencerMarketing.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
