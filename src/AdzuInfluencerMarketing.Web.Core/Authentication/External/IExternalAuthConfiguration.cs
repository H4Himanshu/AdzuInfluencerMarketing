using System.Collections.Generic;

namespace AdzuInfluencerMarketing.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
