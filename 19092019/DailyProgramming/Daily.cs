using System;

namespace DailyProgramming
{
    public class Daily
    {
        /*
         * Given the mapping a = 1, b = 2, ..., z = 26, 
         * and an encoded message, count the number of ways it
         * can be decoded.
         * 
         * For example, the message '111' would give 3, since it
         * could be decoded as 'aaa', 'ka' and 'ak'.
         * 
         * You can assume, that the messages are decodeable.
         * For example, '001' is not allowed.
         * 
         */
        public static int Decode(string msg)
        {
            if(msg.Length == 0)
            {
                return 1;
            }
            int ways = 0;
            if(msg.Length >= 1)
            {
                if (msg[msg.Length - 1] > '0')
                {
                    ways = Decode(msg.Substring(0, msg.Length - 1));
                }
            }
            if(msg.Length >= 2)
            {
                if (msg[msg.Length - 2] == '1' || (msg[msg.Length - 2] == '2' && msg[msg.Length - 1] < '7'))
                {
                    ways += Decode(msg.Substring(0, msg.Length - 2));
                }
            }

            return ways;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
