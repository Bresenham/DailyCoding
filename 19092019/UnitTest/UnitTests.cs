using Microsoft.VisualStudio.TestTools.UnitTesting;

using DailyProgramming;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstTest()
        {
            /* Arrange */
            string s = "111";

            /* Act */
            int returnNumber = Daily.Decode(s);

            /* Assert */
            Assert.AreEqual(returnNumber, 3);
        }

        [TestMethod]
        public void SecondTest()
        {
            /* Arrange */
            string s = "1090";

            /* Act */
            int returnNumber = Daily.Decode(s);

            /* Assert */
            Assert.AreEqual(returnNumber, 0);
        }

        [TestMethod]
        public void ThirdTest()
        {
            /* Arrange */
            string s = "12321";

            /* Act */
            int returnNumber = Daily.Decode(s);

            /* Assert */
            Assert.AreEqual(returnNumber, 6);
        }

        [TestMethod]
        public void FourthTest()
        {
            /* Arrange */
            string s = "1234";

            /* Act */
            int returnNumber = Daily.Decode(s);

            /* Assert */
            Assert.AreEqual(returnNumber, 3);
        }
    }
}
