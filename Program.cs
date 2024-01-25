using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolRoutePlanner
{
    class Program
    {
        // Instantiate Random variable
        public static Random random = new Random();

        static void Main(string[] args)
        {
            // Constant variable
            const int NUM_OF_POOLS = 7;

            // Create an array for the pools
            Pool[] poolsArr = new Pool[NUM_OF_POOLS];

            // Create a string array of pool references
            string[] poolName = new string[] { "A", "B", "C", "D", "E", "F", "G" };

            // Instantiate the objects
            Pool A = new Pool("A", RandomNumber(), 4, 8);
            poolsArr[0] = A;
            Pool B = new Pool("B", RandomNumber(), 1, 3);
            poolsArr[1] = B;
            Pool C = new Pool("C", RandomNumber(), 4, 2);
            poolsArr[2] = C;
            Pool D = new Pool("D", RandomNumber(), 13, 1);
            poolsArr[3] = D;
            Pool E = new Pool("E", RandomNumber(), 12, 9);
            poolsArr[4] = E;
            Pool F = new Pool("F", RandomNumber(), 10, 5);
            poolsArr[5] = F;
            Pool G = new Pool("G", RandomNumber(), 6, 6);
            poolsArr[6] = G;

            // Have maintaince go around and change the pool temperatures and Display info
            poolsArr[0].FindDistance(poolsArr);
        }

        // Random number generator function to avoid repeated numbers
        public static double RandomNumber()
        {
            return Math.Round((random.NextDouble() * (104 - 98) + 98), 1);
        }
    }
}
