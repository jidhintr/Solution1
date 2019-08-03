using System;
using System.Threading;

namespace Demo1_StaricaseClimbing
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var stairCounts = 25;
            var maxSteps = 2;

            Console.WriteLine($"Count number of ways to climb {stairCounts} by maximum of" +
                              $" {maxSteps} at a time");
            Console.WriteLine("-".PadRight(100, '-'));

            var t1 = new Thread(() =>
                Console.WriteLine($"Brute Force Approach = {BruteForce.CountWays(stairCounts)}"));
            var t2 = new Thread(() =>
                Console.WriteLine($"Enhanced Approach   = { Enhanced.CountWays(stairCounts, maxSteps)}"));
            var t3 = new Thread(() =>
                Console.WriteLine($"Dynamic Programming = { DynamicProgram.CountWays(stairCounts, maxSteps)}"));

            t1.Start();
             t2.Start();
           t3.Start();
            Console.ReadLine();
        }


    }
}
