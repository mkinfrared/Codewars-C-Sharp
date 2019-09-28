using System;

namespace Codewars
{
    public class Recursion
    {
        public static ulong Factorial(ulong n)
        {
            checked
            {
                if (n <= 1) return 1;

                ulong result = n * Factorial(n - 1);

                return result;

//                return n == 0 ? 1 : n*Factorial(n - 1);
//                return (n < 2) ? 1 : n * Factorial(n - 1);
            }
        }
    }
}
