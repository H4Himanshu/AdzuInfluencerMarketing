using System.Threading.Tasks;
using AdzuInfluencerMarketing.Models.TokenAuth;
using AdzuInfluencerMarketing.Web.Controllers;
using Shouldly;
using Xunit;

namespace AdzuInfluencerMarketing.Web.Tests.Controllers
{
    public class HomeController_Tests: AdzuInfluencerMarketingWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}