using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
    /// Take a Ten Minute Walk
    /// </summary>
    public class TakeATenMinuteWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            int sumN = 0;
            int sumS = 0;
            int sumE = 0;
            int sumW = 0;

            for (int i = 0; i < walk.Length; i++)
            {
                if (walk[i] == "n") sumN++;
                else if (walk[i] == "s") sumS++;
                else if (walk[i] == "e") sumE++;
                else if (walk[i] == "w") sumW++;
            }

            return (sumN == sumS && sumE == sumW && walk.Length > 0 && walk.Length == 10);
        }
    }
}
