namespace Demo1_StaricaseClimbing
{
    internal static class DynamicProgram
    {
        static int CountWaysUtil(int n, int m)
        {
            var res = new int[n];
            res[0] = 1; res[1] = 1;
            for (var i = 2; i < n; i++)
            {
                res[i] = 0;
                for (var j = 1; j <= m && j <= i; j++)
                    res[i] += res[i - j];
            }
            return res[n - 1];
        }

        public static int CountWays(int s, int m) => CountWaysUtil(s + 1, m);
    }
}