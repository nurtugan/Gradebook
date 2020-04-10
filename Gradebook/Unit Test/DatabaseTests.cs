namespace Gradebook.Unit_Test
{
    using NUnit.Framework;
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestMethod0()
        {
            Assert.NotNull(Database.shared.students);
        }
    }
}