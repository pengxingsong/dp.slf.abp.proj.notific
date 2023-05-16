using System.Threading.Tasks;
using DPNotific.Models.TokenAuth;
using DPNotific.Web.Controllers;
using Shouldly;
using Xunit;

namespace DPNotific.Web.Tests.Controllers
{
    public class HomeController_Tests: DPNotificWebTestBase
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