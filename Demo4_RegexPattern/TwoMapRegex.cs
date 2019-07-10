using System.Collections.Generic;

namespace Demo4_RegexPattern
{
    class TwoMapRegex
    {
        public List<string> findAndReplacePattern(string[] words, string pattern)
        {
            var ans = new List<string>();
            foreach (var word in words)
            {
                if (match(word, pattern))
                    ans.Add(word);
            }

            return ans;
        }

        public bool match(string word, string pattern)
        {
            var m1 = new Dictionary<char, char>();
            var m2 = new Dictionary<char, char>();
            for (int i = 0; i < word.Length; ++i)
            {
                char w = word[i];
                char p = pattern[i];
                if (!m1.ContainsKey(w)) m1.Add(w, p);
                if (!m2.ContainsKey(p)) m2.Add(p, w);
                if (m1[w] != p || m2[p] != w)
                    return false;
            }

            return true;
        }
    }
}