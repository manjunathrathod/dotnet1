using Xunit;
using MyApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIndexView()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
