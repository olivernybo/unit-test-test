using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace Test
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void Add()
        {
			Assert.AreEqual(Example.Add(1, 2), 3, "1 + 2 does not equal 3");
        }
    }
}
