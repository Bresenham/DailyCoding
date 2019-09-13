using Microsoft.VisualStudio.TestTools.UnitTesting;

using DailyProgramming;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BasicTest()
        {
            /* Arrange */
            ListNode first = new ListNode(2);
            first.next = new ListNode(4);
            first.next.next = new ListNode(3);

            ListNode scnd = new ListNode(5);
            scnd.next = new ListNode(6);
            scnd.next.next = new ListNode(4);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, scnd);

            /* Assert - This would be 342 + 465 = 807 */
            Assert.AreEqual(result.val, 7);
            Assert.AreEqual(result.next.val, 0);
            Assert.AreEqual(result.next.next.val, 8);

            Assert.AreSame(result.next.next.next, null);
        }

        [TestMethod]
        public void UnevenLengthNumberTest()
        {
            /* Arrange */
            ListNode first = new ListNode(1);
            first.next = new ListNode(2);

            ListNode scnd = new ListNode(5);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, scnd);

            /* Assert - This would be 21 + 5 = 26 */
            Assert.AreEqual(result.val, 6);
            Assert.AreEqual(result.next.val, 2);
        }

        [TestMethod]
        public void ZeroNumberFirstTest()
        {
            /* Arrange */
            ListNode first = new ListNode(0);

            ListNode scnd = new ListNode(1);
            scnd.next = new ListNode(1);
            scnd.next.next = new ListNode(0);
            scnd.next.next.next = new ListNode(3);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, scnd);

            /* Assert - This would be 0 + 3011 = 3011 */
            Assert.AreEqual(result.val, 1);
            Assert.AreEqual(result.next.val, 1);
            Assert.AreEqual(result.next.next.val, 0);
            Assert.AreEqual(result.next.next.next.val, 3);
        }

        [TestMethod]
        public void ZeroNumberScndTest()
        {
            /* Arrange */
            ListNode first = new ListNode(2);
            first.next = new ListNode(1);
            first.next.next = new ListNode(7);
            first.next.next.next = new ListNode(9);

            ListNode scnd = new ListNode(0);


            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, scnd);

            /* Assert - This would be 9712 + 0 = 9712 */
            Assert.AreEqual(result.val, 2);
            Assert.AreEqual(result.next.val, 1);
            Assert.AreEqual(result.next.next.val, 7);
            Assert.AreEqual(result.next.next.next.val, 9);
        }

        [TestMethod]
        public void OverheadAdditionTest()
        {
            /* Arrange */
            ListNode first = new ListNode(2);
            first.next = new ListNode(3);

            ListNode second = new ListNode(8);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, second);

            /* Assert - This would be 32 + 8 = 40 */
            Assert.AreEqual(result.val, 0);
            Assert.AreEqual(result.next.val, 4);
        }

        [TestMethod]
        public void OverheadAdditionTest2()
        {
            /* Arrange */
            ListNode first = new ListNode(3);
            first.next = new ListNode(3);

            ListNode second = new ListNode(9);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, second);

            /* Assert - This would be 33 + 9 = 42 */
            Assert.AreEqual(result.val, 2);
            Assert.AreEqual(result.next.val, 4);
        }

        [TestMethod]
        public void NewDigitAfterAddition()
        {
            /* Arrange */
            ListNode first = new ListNode(4);

            ListNode second = new ListNode(6);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, second);

            /* Assert - This would be 4 + 6 = 10 */
            Assert.AreEqual(result.val, 0);
            Assert.AreEqual(result.next.val, 1);
        }

        [TestMethod]
        public void NewDigitAfterAddition2()
        {
            /* Arrange */
            ListNode first = new ListNode(5);

            ListNode second = new ListNode(6);

            /* Act */
            ListNode result = Daily.AddTwoNumbers(first, second);

            /* Assert - This would be 5 + 6 = 11 */
            Assert.AreEqual(result.val, 1);
            Assert.AreEqual(result.next.val, 1);
        }
    }
}
