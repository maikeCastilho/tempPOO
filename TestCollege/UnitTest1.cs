using CollegeOOP;

namespace TestCollege
{
    [TestClass]
    public class CalcTest
    {
        public void TestSumToIntNumber()
        {
            Sum sum = new Sum();

            int x = 4;
            int y = 5;

            int result = sum.SumToNumbers(x, y);

            Assert.AreEqual(9, result);

        }
    }
}