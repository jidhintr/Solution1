using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_RegexPattern
{
    class program
    {
        static void Main(string[] args)
        {
            var one = new OneMapRegex();
            var two = new TwoMapRegex();
            var words = new[] { "abc", "deq", "mee", "aqq", "ccc","eep","eddd" };
            const string pattern = "abbb";

            var res1 = one.findAndReplacePattern(words, pattern);
            var res2 = two.findAndReplacePattern(words, pattern );
            res1.ForEach(Console.WriteLine);
            Console.WriteLine("Second Approach");
            res2.ForEach(Console.WriteLine);
            Console.ReadKey();

        }
    }



}
