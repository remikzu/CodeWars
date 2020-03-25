using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp
    /// Shortest Word
    /// </summary>
    public class ShortestWord
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').OrderBy(w => w.Length).ToList().First().Length;
        }
    }
}
