using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    /// <summary>
    /// https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8/train/csharp
    /// Vasya - Clerk
    /// </summary>
    public class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            int moneyForChange = 0;
            int ticketPrice = 25;
            int count25 = 0;
            int count50 = 0;
            int count100 = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                {
                    count25++;
                    moneyForChange += peopleInLine[i];
                }
                else if (peopleInLine[i] == 50)
                {
                    count50++;
                    if (count25 > 0)
                    {
                        moneyForChange += peopleInLine[i];
                        moneyForChange -= ticketPrice;
                        count25--;
                    }
                    else
                    {
                        return "NO";
                    }
                }
                else if (peopleInLine[i] == 100)
                {
                    count100++;
                    if (count50 > 0 && count25 > 0)
                    {
                        moneyForChange += peopleInLine[i];
                        moneyForChange -= (peopleInLine[i] - ticketPrice);
                        count50--;
                        count25--;
                    }
                    else if (count25 >= 3)
                    {
                        moneyForChange += peopleInLine[i];
                        moneyForChange -= (peopleInLine[i] - ticketPrice);
                        count25 -= 3;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            
            return moneyForChange >= 0 && (count25 > 0 || count50 > 0 || count100 > 0) ? "YES" : "NO";
        }
    }
}
