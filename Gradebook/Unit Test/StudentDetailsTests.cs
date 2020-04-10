using Gradebook.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Unit_Test
{
    using NUnit.Framework;
    [TestFixture]
    public class StudentDetailsTests
    {
        [Test]
        public void TestMethod0()
        {
            var controller = new StudentDetails();
            var result = controller.Details("AnyHash") as ViewResult;
            Assert.AreEqual("StudentDetails", result.ViewName);
        }
    }
}