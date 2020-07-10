using System;
using System.Text.RegularExpressions;

namespace abbreviation
{
    class Program
    {
        // Code challenge https://www.codewars.com/kata/5375f921003bf62192000746/train/csharp
        static void Main(string[] args)
        {
            string[] q = ("elephant-rides are really fun!").Split(new Char[]{' ','-'});

            foreach (string i in q)
            {
                if((i.Length >= 4) && (Regex.IsMatch(i, "[aA-zZ]")))
                {
                        Console.WriteLine($"Word {i}");

                }

            }
        }
    }
}
