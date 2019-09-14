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
            int[] nums = { 10, 15, 3, 7 };
            int x = 17;

            /* Act */
            bool result = Daily.AddsUpTo(nums, x);

            /* Assert */
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SecondTest()
        {
            /* Arrange */
            int[] nums = { 5, 9, 2, 1 };
            int x = 8;

            /* Act */
            bool result = Daily.AddsUpTo(nums, x);

            /* Assert */
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ThirdTest()
        {
            /* Arrange */
            int[] nums = { 3, 1, 10, 100, 1000 };
            int x = 1100;

            /* Act */
            bool result = Daily.AddsUpTo(nums, x);

            /* Assert */
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FourthTest()
        {
            /* Arrange */
            int[] nums = { 1, 2, 3, 5 };
            int x = 6;

            /* Act */
            bool result = Daily.AddsUpTo(nums, x);

            /* Assert */
            Assert.IsTrue(result);
        }
    }
}
