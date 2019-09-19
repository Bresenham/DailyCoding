using System;

namespace DailyProgramming
{
    public class Daily
    {
        /*
         * The string "PAYPALISHIRING" is written in a zigzag pattern on
         * a given number of rows like this:
         * 
         * P   A   H   N
         * A P L S I I G
         * Y   I   R
         * 
         * And then read line by line: "PAHNAPLSIIGYIR"
         * 
         * Write the code that will take a string and make this conversion given a number of rows.
         */ 
        public static string Convert(string s, int numRows)
        {
            int maximumJump = (numRows - 2) * 2 + 2;
            string returnString = "";
            for(int r = 0; r < numRows; r++)
            {
                int i = r;
                int currentJump = (numRows - r - 2) * 2 + 2;
                int[] alternatingJumps = { currentJump, maximumJump - currentJump };
                int alternatingIndex = 0;
                while (i < s.Length)
                {
                    returnString += s[i];
                    if(r == 0 || r == numRows - 1)
                    {
                        i += maximumJump;
                    } else
                    {
                        i += alternatingJumps[alternatingIndex];
                        alternatingIndex += 1;
                        alternatingIndex = alternatingIndex % 2;
                    }
                }
            }

            return returnString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
