﻿using System;

// Your task is to make function, which returns the sum of a sequence of integers.
// The sequence is defined by 3 non-negative values: begin, end, step.
// If begin value is greater than the end, function should returns 0

// Examples
// SequenceSum (2,2,2); // => 2
// SequenceSum (2,6,2); // => 12 -> 2 + 4 + 6
// SequenceSum (1,5,1); // => 15 -> 1 + 2 + 3 + 4 + 5
// SequenceSum (1,5,3); // => 5 -> 1 + 4

namespace Sum_Sequence
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(SequenceSum(2, 2, 2));
          }

          public static int SequenceSum(int start, int end, int step)
          {
               int results = 0;

               if (start >= 0 && end >= 0 && step >= 0)
               {
                    if (start > end)
                    {
                         return 0;
                    }
                    else
                    {
                         //  results = start + end + step;
                         while (start < end)
                         {
                              results = start + step;
                         }
                    }

               }
               else
               {
                    return 0;
               }

               return results;
          }
     }
}
