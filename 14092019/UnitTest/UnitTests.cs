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
            string s = "abcabcbb";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestString2()
        {
            /* Arrange */
            string s = "bbbbb";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestString3()
        {
            /* Arrange */
            string s = "pwwkew";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestString4()
        {
            /* Arrange */
            string s = "ukalebz";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, s.Length);
        }

        [TestMethod]
        public void TestString5()
        {
            /* Arrange */
            string s = "nanananananb";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestString6()
        {
            /* Arrange */
            string s = "aaaaaaaaaaaabaaaaaaa";

            /* Act */
            int result = Daily.LengthOfLongestSubstring(s);

            /* Assert */
            Assert.AreEqual(result, 2);
        }
    }
}
