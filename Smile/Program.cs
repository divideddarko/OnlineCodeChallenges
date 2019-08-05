using System;
using System.Text.RegularExpressions;

namespace Smile
{
     class Program
     {
          public static int CountSmileys(string[] smileys)
          {
               int Count = 0;

               Regex rgx = new Regex("[:;]{1}[-~]?[)D]{1}");

               foreach (string Smile in smileys)
               {
                    if (rgx.IsMatch(Smile))
                    {
                         Count++;
                    }
               }

               return Count;
          }
     }
}
