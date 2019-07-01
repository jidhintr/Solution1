namespace Demo1_StaricaseClimbing
{
    internal static class BruteForce
    {
        static int Fibinocci(int n)
        {
            if (n <= 1)
                return n;
            var result= Fibinocci(n - 1) + Fibinocci(n - 2);
            return result;
        }

        public static int CountWays(int s) => Fibinocci(s + 1);
    }
}
