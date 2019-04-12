using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiCdExample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue((1 + 1) == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue((1 + 2) == 3);
        }
    }
}
