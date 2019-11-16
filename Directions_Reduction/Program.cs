using System;
using System.Collections.Generic;

namespace Directions_Reduction
{
     class Program
     {
          static void Main(string[] args)
          {
               String[] a = { "NORTH", "SOUTH", "EAST", "WEST" };
               Console.WriteLine(dirReduc(a));
          }

          public static string[] dirReduc(String[] arr)
          {
               List<String> finalPath = new List<string>();
               int[,] locations = new int[,] { };
               int NS = 0;
               int EW = 0;

               foreach (String path in arr)
               {
                    Console.WriteLine("working on : " + path);
                    switch (path)
                    {
                         case "NORTH":
                              locations.SetValue(NS++, EW);
                              break;
                         case "SOUTH":
                              locations.SetValue(NS--, EW);
                              break;
                         case "EAST":
                              locations.SetValue(NS, EW++);
                              break;
                         case "WEST":
                              locations.SetValue(NS, EW--);
                              break;
                         default:
                              break;
                    }
                    foreach (int i in locations)
                    {
                         Console.WriteLine("i: " + i);
                    }

               }



               return finalPath.ToArray();
          }
     }
}
