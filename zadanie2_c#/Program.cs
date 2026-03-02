using System;

namespace zadanie2
{
    public class Logic
    {
        public static int Multiply(int x, int y)
        {
            int res = 0;

            for (int i = 0; i < y; i++)
            {
                res = res + x;
            }

            return res;
        }
    }

    
}
