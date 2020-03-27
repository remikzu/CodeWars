using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp
    /// Split Strings
    /// </summary>
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1]);
            }

            return list.ToArray();
        }
    }
}
