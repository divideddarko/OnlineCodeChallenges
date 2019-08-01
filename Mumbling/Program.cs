using System;
using System.Text;

// This time no story, no theory. The examples below show you how to write function accum:
// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

namespace Mumbling
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(Accum("MjtkuBovqrU"));
          }

          public static String Accum(string s)
          {
               char[] brokenLetters = s.ToCharArray();
               StringBuilder mumble = new StringBuilder();

               for (int i = 0; i < brokenLetters.Length; i++)
               {
                    for (int cl = 0; cl <= i; cl++)
                    {
                         if (cl == 0)
                         {

                              mumble.Append(brokenLetters[i].ToString().ToUpper());
                         }
                         else
                         {
                              mumble.Append(brokenLetters[i].ToString().ToLower());
                         }
                    }

                    if (i >= 0 && i < brokenLetters.Length - 1)
                    {
                         mumble.Append("-");
                    }
               }

               return mumble.ToString();
          }
     }
}
