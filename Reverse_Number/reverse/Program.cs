using System;

namespace reverse
{
    // https://leetcode.com/problems/reverse-integer/
    class Program
    {
        static void Main(string[] args)
        {
            int results = reverse(-123);
            Console.WriteLine($"output {results}");
        }

        public static int reverse(int x)
        {
            char[] convertInt = x.ToString().ToCharArray();
            string newNum = "";

            foreach (char p in convertInt)
            {
                string stringNum = Convert.ToString(p);
                newNum = $"{stringNum}{newNum}";
            }

            if (newNum.Contains("-"))
            {
                newNum = newNum.Replace("-", "");
                newNum = $"-{newNum}";
            }

            int newValue = 0;

            try
            {
                newValue = Convert.ToInt32(newNum);
            }
            catch
            {
                return 0;
            }

            return newValue;
        }
    }
}
