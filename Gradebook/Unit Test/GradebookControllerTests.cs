using Gradebook.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Unit_Test
{
    using NUnit.Framework;
    [TestFixture]
    public class GradebookControllerTests
    {
        [Test]
        public void TestMethod0()
        {
            var controller = new GradebookController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(null, result.ViewName);
        }
    }
}