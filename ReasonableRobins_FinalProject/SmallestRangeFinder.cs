using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReasonableRobins_FinalProject
{
    public partial class SmallestRangeFinder
    {
        /// <summary>
        /// Calculates the minimum number of operations to transform an integer n to 0 using the given operations.
        /// </summary>
        /// <param name="n">The integer to transform.</param>
        /// <returns>The minimum number of operations required.</returns>
        public int MinOperations(int n)
        {
            int count = 0;
            while (n > 0)
            {
                int consecutiveOnes = 0;
                int temp = n;
                while ((temp & 1) == 1)
                {
                    consecutiveOnes++;
                    temp >>= 1;
                }

                Console.WriteLine($"n: {n}, consecutiveOnes: {consecutiveOnes}");

                if (consecutiveOnes > 2)
                {
                    count++;
                    n ^= (1 << consecutiveOnes) - 1;
                }
                else if (consecutiveOnes == 2)
                {
                    count++;
                    n >>= 2;
                }
                else
                {
                    count += 2;
                    n >>= 2;
                }
            }
            return count;
        }
    }
}