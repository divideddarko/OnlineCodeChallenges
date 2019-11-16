using System;
using System.Collections.Generic;

namespace Detect_Pangram
{
    class Program
    {
        protected static string str { get; } = "Hello World";
        static void Main(string[] args)
        {
            bool results = CheckPangram();
            Console.Write(results);
        }

        static bool CheckPangram()
        {

            List<string> Alphabet = new List<string>(new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });

            foreach (char letter in str.ToLower())
            {
                if (Alphabet.Contains((letter).ToString()))
                {
                    Alphabet.Remove((letter).ToString());
                }
            }

            if (Alphabet.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
}
