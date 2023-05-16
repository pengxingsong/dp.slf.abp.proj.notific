using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DP.NotificApp.Pages;

public class Index_Tests : NotificAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
