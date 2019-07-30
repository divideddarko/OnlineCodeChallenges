using System;
using System.Collections.Generic;

// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

// Example:

// Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
// Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
// Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
// Notes:

// All numbers are valid Int32, no need to validate them.
// There will always be at least one number in the input string.
// Output string must be two numbers separated by a single space, and highest number is first.

namespace Highest_Lowest
{
     class Program
     {

          static void Main(string[] args)
          {
               Console.WriteLine(HighAndLow("1 2 3 4 56"));
          }

          public static string HighAndLow(string numbers)
          {
               //   split string and convert to int32
               String[] q = numbers.Split(" ");
               List<int> arr = new List<int>();
               int Min = 0;
               int Max = 0;

               for (int i = 0; i < q.Length; i++)
               {
                    arr.Add(Convert.ToInt32(q[i]));
               }

               for (int i = 0; i < arr.Count; i++)
               {

                    if (arr[0] == arr[i])
                    {
                         Min = arr[0];
                         Max = arr[0];
                    }
                    else
                    {
                         if (Min > arr[i])
                         {
                              Min = arr[i];
                         }
                         if (Max < arr[i])
                         {
                              Max = arr[i];
                         }
                    }
               }
               return $"{Max} {Min}";
          }
     }
}
