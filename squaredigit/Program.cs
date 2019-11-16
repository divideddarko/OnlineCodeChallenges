using System;

namespace squaredigit
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(SquareDigits(1));
          }


          public static int SquareDigits(int n)
          {
               string q = n.ToString();
               string results = "";

               foreach (char num in q)
               {
                    int p = Convert.ToInt32(num);
                    results += p * p;
                    Console.WriteLine($"Sum: {p}*{p}");
               }

               Console.WriteLine($"Results: {results}");
               return Convert.ToInt32(results);
          }
     }
}
