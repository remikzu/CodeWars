using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/578553c3a1b8d5c40300037c/train/csharp
    /// Ones and Zeros
    /// </summary>
    public class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            var result = 0;
            var ReversedArray = BinaryArray.Reverse().ToArray();
            for (int i = 0; i <= ReversedArray.Length-1; i++)
            {
                if (ReversedArray[i] == 1)
                {
                    result += (int)Math.Pow(2, i);
                }
                else result += 0;
            }
            return result;
        }
        //This is best result:
        /*public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray), 2);
        }*/
    }
}
