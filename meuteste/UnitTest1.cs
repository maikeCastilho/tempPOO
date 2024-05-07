using CollegeOOP;
using System.Xml.XPath;

namespace superTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sum sum = new Sum();
            int result = sum.SumToNumbers(4, 5);
            Assert.AreEqual(9, result);
        }
    }
}