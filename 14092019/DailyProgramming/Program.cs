using System;

namespace DailyProgramming
{
    public class Daily
    {
        /*
         * Given a string, find the length of the longest substring without repeating characters.
         * abcabcbb => 3 (abc)
         * bbbbb => 1 (b)
         * pwwkew => 3 (wke)
         */

        public static int LengthOfLongestSubstring(string s)
        {
            int j = 0;
            int i = 1;
            int maxSubstringLength = 0;
            for (; i < s.Length; )
            {
                bool hasRepeatingChar = false;
                char nextChar = s[i];
                for(int jTemp = j; jTemp < i; jTemp++)
                {
                    if(s[jTemp] == nextChar)
                    {
                        hasRepeatingChar = true;
                        break;
                    }
                }

                if(hasRepeatingChar)
                {
                    j += 1;
                } else
                {
                    if (i - j > maxSubstringLength)
                    {
                        maxSubstringLength = i - j;
                    }
                    i += 1;
                }

            }

            return maxSubstringLength + 1;
        }
        static void Main(string[] args)
        {

        }
    }
}
