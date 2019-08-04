using System;
using System.Collections.Generic;

// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp


// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
// It should remove all values from list a, which are present in list b.
// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
// If a value is present in b, all of its occurrences must be removed from the other:
// Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

namespace Array_Diff
{
     class Program
     {
          static void Main(string[] args)
          {
               int[] results = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 });
               foreach (int i in results)
               {
                    Console.WriteLine(i);
               }
          }


          public static int[] ArrayDiff(int[] a, int[] b)
          {
               List<int> found = new List<int>();

               foreach (int i in a)
               {
                    foreach (int j in b)
                    {
                         if (j != i)
                         {
                              if (found.Count < 1)
                              {
                                   found.Add(i);
                              }

                              for (int p = 0; p < found.Count; p++)
                              {
                                   if (i != found[p])
                                   {
                                        found.Add(i);

                                   }
                              }

                         }
                    }
               }

               int[] arr = new int[found.Count];
               found.CopyTo(arr);
               return arr;
          }
     }
}
