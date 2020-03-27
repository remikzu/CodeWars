using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
    /// Convert String To Camel Case
    /// </summary>
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            var sB = new StringBuilder();
            var listOfChars = str.ToCharArray().ToList();
            for (int i = 0; i < listOfChars.Count; i++)
            {
                if (listOfChars[i] == '-' || listOfChars[i] == '_')
                {
                    listOfChars.RemoveAt(i);
                    sB.Append(Char.ToUpper(listOfChars[i]));
                }
                else
                {
                    sB.Append(listOfChars[i]);
                }
            }
            return sB.ToString();
        }
    }
}
