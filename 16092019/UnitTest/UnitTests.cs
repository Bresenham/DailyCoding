using Microsoft.VisualStudio.TestTools.UnitTesting;

using DailyProgramming;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstTetst()
        {
            /* Arrange */
            string s = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(s, 3);

            /* Assert */
            Assert.AreEqual(returnString, "PAHNAPLSIIGYIR");
        }

        [TestMethod]
        public void SecondTest()
        {
            /* Arrange */
            string s = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(s, 4);

            /* Assert */
            Assert.AreEqual(returnString, "PINALSIGYAHRPI");
        }

        [TestMethod]
        public void ThirdTest()
        {
            /* Arrange */
            string s = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(s, 5);

            /* Assert */
            Assert.AreEqual(returnString, "PHASIYIRPLIGAN");
        }

        [TestMethod]
        public void FourthTest()
        {
            /* Arrange */
            string s = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(s, 6);

            /* Assert */
            Assert.AreEqual(returnString, "PRAIIYHNPSGAIL");
        }

        [TestMethod]
        public void FithTest()
        {
            /* Arrange */
            string s = "PAYPALISHIRING";

            /* Act */
            string returnString = Daily.Convert(s, 2);

            /* Assert */
            Assert.AreEqual(returnString, "PYAIHRNAPLSIIG");
        }
    }
}
