using System.Collections.Generic;

namespace EveryDemoUnitTest
{
    internal static class Helper
    {
        public static string ListToString(this List<string> listJobs)
        {
            return string.Join("", listJobs.ToArray());
        }
    }
}