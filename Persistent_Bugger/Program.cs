using System;
using System.Collections.Generic;
using System.Linq;

// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
// For example:
//  persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
// and 4 has only one digit
//  persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
// 1*2*6 = 12, and finally 1*2 = 2
//  persistence(4) == 0 // because 4 is already a one-digit number

namespace Persistent_Bugger
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(Persistence(999));
          }

          public static long Persistence(long n)
          {
               int loopCount = 0;
               long sumTotal = n;

               if (sumTotal < 9)
               {
                    return loopCount;
               }

               do
               {
                    long[] d = sumTotal.ToString().ToCharArray().Select(x => (long)Char.GetNumericValue(x)).ToArray();

                    sumTotal = d[0];
                    for (int i = 1; i < d.Length; i++)
                    {
                         sumTotal = d[i] * sumTotal;
                    }
                    loopCount++;
               } while (sumTotal > 9);
               return loopCount;
          }
     }
}
