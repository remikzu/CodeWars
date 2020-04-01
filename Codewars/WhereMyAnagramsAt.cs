using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/523a86aa4230ebb5420001e1/train/csharp
    /// Where my anagrams at?
    /// </summary>
    public class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var wordToChars = String.Concat(word.OrderBy(c => c));

            for (int i = 0; i < words.Count; ++i)
            {
                if (wordToChars.Length != words[i].Length)
                {
                    words.RemoveAt(i);
                    i--;
                }
                else
                {
                    var wordToCheck = String.Concat(words[i].OrderBy(c => c));
                    if (!wordToChars.SequenceEqual(wordToCheck))
                    {
                        words.RemoveAt(i);
                        i--;
                    }
                }
            }
            
            return words;
        }

        //Shortest version
        /*public static List<string> Anagrams(string word, List<string> words)
        {
            var pattern = word.OrderBy(p => p).ToArray();
            return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
        }*/

    }
}
