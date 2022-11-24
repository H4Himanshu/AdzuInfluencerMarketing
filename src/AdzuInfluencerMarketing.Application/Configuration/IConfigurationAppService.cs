using System.Threading.Tasks;
using AdzuInfluencerMarketing.Configuration.Dto;

namespace AdzuInfluencerMarketing.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
