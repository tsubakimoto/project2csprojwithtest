using Microsoft.AspNetCore.Mvc;
using Project2CsprojWithTest.Controllers;
using Xunit;

namespace Project2CsprojWithTest.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            var ctrl = new HomeController();
            var acturl = ctrl.Index();
            Assert.IsType<ViewResult>(acturl);
        }
    }
}
