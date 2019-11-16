using System;
using System.Text.RegularExpressions;

// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

namespace x_and_o
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(XO("xoxoxo"));
          }

          public static bool XO(string input)
          {
               bool result = false;
               int countX = 0;
               int countO = 0;

               Regex x = new Regex("[xX]");
               Regex o = new Regex("[oO]");

               foreach (char letter in input)
               {
                    String l = letter.ToString();
                    if (x.IsMatch(l))
                    {
                         countX++;
                    }

                    if (o.IsMatch(l))
                    {
                         countO++;
                    }
               }

               if (countX == countO)
               {
                    result = true;
               }

               return result;
          }
     }
}
