using almtestet2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int hej = 5;
            Assert.AreEqual(7, hej);
        }

        [TestMethod]
        public void MakaperTest1()
        {
            var m = new Makaper();
            var res = m.Dublera(5);
            var expected = 10;
            Assert.AreEqual(expected, res);
        }
    }
}
