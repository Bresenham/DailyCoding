using System;

namespace DailyProgramming
{
    public class Daily
    {
        /*
         * The string "PAYPALISHIRING" is written in a zigzag pattern
         * on a given number of rows like this:
         * 
         * P   A   H   N
         * A P L S I I G
         * Y   I   R
         * 
         * And then read line by line: "PAHNAPLSIIGYIR.
         * 
         * Write the code that will take a string and make this conversion
         * given a number of rows.
         * 
         */ 

        public static string Convert(string s, int numRows)
        {
            string returnString = "";

            
            for(int r = 0; r < numRows; r++)
            {
                int i = r;
                while (i < s.Length)
                {
                    returnString += s[i];
                    if(r == 0 || r == numRows - 1)
                    {
                        i += numRows + 1;
                    } else
                    {
                        i += (numRows - r - 1) * 2;
                    }
                }
            }

            return returnString;
        }
        public static void Main(string[] args)
        {
            
        }
    }
}
