namespace Demo1_StaricaseClimbing
{
    internal static class Enhanced
    {
        static int CountWaysUtil(int n, int m)
        {
            if (n <= 1)
                return n;
            var res = 0;

            for (var i = 1; i <= m && i <= n; i++)
                res += CountWaysUtil(n - i, m);
            return res;
        }

        public static int CountWays(int s, int m) => CountWaysUtil(s + 1, m);
    }
}