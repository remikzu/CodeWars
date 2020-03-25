using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/5679aa472b8f57fb8c000047/train/csharp
    /// Equal Sides Of An Array
    /// </summary>
    public class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum == 0) return 0;

            for (int i = 0; i < arr.Length; i++)
            {                
                var sumRight = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }

                var sumLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }

                if (sumRight == sumLeft) return i;
            }

            return -1;
        }
    }
}
