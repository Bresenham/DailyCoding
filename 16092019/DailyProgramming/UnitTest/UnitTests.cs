using Microsoft.VisualStudio.TestTools.UnitTesting;

using DailyProgramming;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestString1()
        {
            /* Arrange */
            string test = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(test, 3);

            /* Assert */
            Assert.AreEqual(returnString, "PAHNAPLSIIGYIR");
        }
    }
}
