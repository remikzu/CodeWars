using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://www.codewars.com/kata/550f22f4d758534c1100025a/csharp
/// Directions Reduction
/// </summary>
namespace Codewars
{
    public class DirectionsReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            Stack<String> stack = new Stack<String>();

            foreach (String direction in arr)
            {
                String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

                switch(direction)
                {
                    case "NORTH": 
                        if ("SOUTH".Equals(lastElement))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(direction);
                        }
                        break;
                    case "SOUTH":
                        if ("NORTH".Equals(lastElement))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(direction);
                        }
                        break;
                    case "EAST":
                        if ("WEST".Equals(lastElement))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(direction);
                        }
                        break;
                    case "WEST":
                        if ("EAST".Equals(lastElement))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(direction);
                        }
                        break;
                }
            }
            String[] result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }
    }
}
