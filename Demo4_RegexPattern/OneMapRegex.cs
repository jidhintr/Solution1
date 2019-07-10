using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo4_RegexPattern
{
    class OneMapRegex
    {


        public List<string> findAndReplacePattern(IEnumerable<string> words, string pattern)
        {
            return words.Where(word => this.Match(word, pattern)).ToList();
        }

        private bool Match(string word, string pattern)
        {
            var dict = new Dictionary<char, char>();
            for (var i = 0; (i < word.Length); i++)
            {
                var w = word[i];
                var p = pattern[i];
                if (!dict.ContainsKey(w))
                {
                    dict.Add(w, p);
                }

                if ((dict[w] != p))
                {
                    return false;
                }

            }

            var seen = new bool[26];
            foreach (var p in dict.Values)
            {
                if (seen[(p - 'a')])
                {
                    return false;
                }

                seen[(p - 'a')] = true;
            }

            return true;
        }
    }
}