using System;

namespace DailyProgramming
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Daily
    {
        /* https://leetcode.com/problems/add-two-numbers/
         * You are given two non-empty linked lists representing two non-negative integers.
         * The digits are stored in reverse order and each of their nodes contain a single digit.
         * Add the two numbers and return it as a linked list.
         * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        */

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Func<ListNode, ListNode, bool> thereAreNextPointers = (lOne, lTwo) => lOne != null && lTwo != null;

            ListNode sumNode = new ListNode(0);
            ListNode returnNode = sumNode;

            int overhead = 0;
            while(thereAreNextPointers(l1, l2))
            {
                int sum = l1.val + l2.val + overhead;
                if(sum >= 10)
                {
                    overhead = 1;
                    sum %= 10;
                } else
                {
                    overhead = 0;
                }
                sumNode.val = sum;

                if(thereAreNextPointers(l1.next, l2.next))
                {
                    sumNode.next = new ListNode(0);
                    sumNode = sumNode.next;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            ListNode notNullNode = l1 != null ? l1 : l2;

            while(notNullNode != null)
            {
                int sum = notNullNode.val + overhead;
                if(sum >= 10)
                {
                    overhead = 1;
                    sum %= 10;
                } else
                {
                    overhead = 0;
                }
                sumNode.next = new ListNode(sum);
                if(notNullNode.next != null)
                {
                    sumNode = sumNode.next;
                }
                notNullNode = notNullNode.next;
            }

            if(overhead != 0)
            {
                sumNode.next = new ListNode(overhead);
            }

            return returnNode;
        }

        static void Main(string[] args)
        {

        }
    }
}
