using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
    /// Stop gninnipS My sdroW
    /// </summary>
    public static class StopSpinningMyWords
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            StringBuilder sB = new StringBuilder();
            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    var wordToAdd = Reverse(word);
                    sB.Append(wordToAdd + ' ');
                }
                else sB.Append(word + ' ');
            }
            return sB.ToString().Trim();
        }

        public static string Reverse(string word)
        {
            StringBuilder sB = new StringBuilder();
            char[] letters = word.ToArray();
            for(int i = letters.Length-1; i >= 0; i--)
            {
                sB.Append(letters[i]);
            }
            return sB.ToString();
        }
    }
}
