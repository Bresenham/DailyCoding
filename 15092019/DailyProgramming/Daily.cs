using System;
using System.Collections;

namespace DailyProgramming
{
    public class Daily
    {
        /*
         * Given a list of numbers and a number x, return whether
         * any two numbers from the list add up to x.
         * [10, 15, 3, 7] with x = 17 => true (10 + 7 = 17)
         * 
         * Is it possible to do this in just one pass => it is!
         */ 
        public static bool AddsUpTo(int[] numbers, int sum)
        {
            Hashtable lookuptable = new Hashtable();
            for(int i = 0; i < numbers.Length; i++)
            {
                lookuptable.Add(i, numbers[i]);
                if(lookuptable.ContainsValue(sum - numbers[i]))
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
