using System;
using System.Text.RegularExpressions;

namespace ROT13
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(Rot13("GfRg"));
          }

          public static string Rot13(string message)
          {
               String newString = "";

               // get current numeric value of character  + 13 convert back to string
               //  example string grfg >
               foreach (char letter in message)
               {
                    int numeric = letter + 13;

                    Regex rgx = new Regex("[a-z]");
                    String l = Convert.ToString(letter);
                    if (rgx.IsMatch(l))
                    {

                         if (numeric > 122)
                         {
                              int toCount = numeric - 122;
                              int newNumber = 96 + toCount;
                              char a = (char)newNumber;
                              newString += a.ToString();
                         }
                         else
                         {
                              char a = (char)numeric;
                              newString += a.ToString();
                         }
                    }
                    else
                    {
                         if (numeric > 90)
                         {
                              int toCount = numeric - 90;
                              int newNumber = 64 + toCount;
                              char a = (char)newNumber;
                              newString += a.ToString();
                         }
                         else
                         {
                              char a = (char)numeric;
                              newString += a.ToString();
                         }
                    }

               }
               return newString;
          }
     }
}
