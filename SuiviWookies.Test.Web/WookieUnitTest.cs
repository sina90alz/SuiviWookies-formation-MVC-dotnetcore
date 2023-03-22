using System;
using Xunit;

namespace SuiviWookies.Test.Web
{
    public class WookieUnitTest
    {
        [Fact]
        public void ShouldRun()
        {
            SuiviWookies.Controllers.WookiesController controller = new(new Core.Services.WookieService());
            Assert.NotNull(controller);
        }
    }
}
