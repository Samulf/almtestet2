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
            int expected = 5;
            Assert.AreEqual(expected, hej);
        }

        [TestMethod]
        public void MakaperDubla()
        {
            var m = new Makaper();
            var res = m.Dublera(5);
            var expected = 10;
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MakaperTripla()
        {
            var m = new Makaper();
            var res = m.Tripla(5);
            var expected = 15;
            Assert.AreEqual(expected, res);
        }
    }
}
