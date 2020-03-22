using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    public class WillYouMakeIt
    {
        /// <summary>
        /// https://www.codewars.com/kata/5861d28f124b35723e00005e/train/csharp
        /// Will you make it?
        /// </summary>
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return mpg * fuelLeft >= distanceToPump;
        }
    }
}
