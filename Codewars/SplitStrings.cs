using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars
{
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
