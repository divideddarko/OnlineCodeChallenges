using System;
using System.Collections.Generic;
using System.Linq;


// Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. If the two numbers are equal return a or b.
// Note: a and b are not ordered!

// Examples
// GetSum(1, 0) == 1   // 1 + 0 = 1
// GetSum(1, 2) == 3   // 1 + 2 = 3
// GetSum(0, 1) == 1   // 0 + 1 = 1
// GetSum(1, 1) == 1   // 1 Since both are same
// GetSum(-1, 0) == -1 // -1 + 0 = -1
// GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2

namespace Sum_of_Numbers
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(GetSum(2, -1));
          }

          public static int GetSum(int a, int b)
          {
               int result = 0;
               List<int> arr = new List<int>();

               if (a == b)
               {
                    result = a;
               }
               else if (a < b)
               {
                    do
                    {
                         arr.Add(a);
                         a++;

                    } while (a <= b);
                    result = arr.Sum();
               }
               else
               {
                    do
                    {
                         arr.Add(b);
                         b++;

                    } while (b <= a);
                    result = arr.Sum();

               }

               return result;
          }
     }
}
