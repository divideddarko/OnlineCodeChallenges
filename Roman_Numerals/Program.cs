using System;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int results = romanToInt("DCXXI");
            Console.WriteLine($"{results}");
        }

        public static int romanToInt(string s)
        {
            char[] numeralsBroken = s.ToCharArray();
            int results = 0;

            for (int n = 0; n < s.Length; n++)
            {
                switch (numeralsBroken[n])
                {
                    case 'I':
                        results = results + 1;
                        break;
                    case 'V':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'I')
                            {
                                results = results + 3;
                            }
                            else
                            {
                                results = results + 5;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {

                            results = results + 5;
                        }
                        break;
                    case 'X':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'I')
                            {
                                results = results + 8;
                            }
                            else
                            {
                                results = results + 10;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {

                            results = results + 10;
                        }
                        break;
                    case 'L':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'X')
                            {
                                results = results + 30;
                            }
                            else
                            {
                                results = results + 50;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {

                            results = results + 50;
                        }
                        break;
                    case 'C':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'X')
                            {
                                results = results + 80;
                            }
                            else
                            {
                                results = results + 100;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {

                            results = results + 100;
                        }
                        break;
                    case 'D':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'C')
                            {
                                results = results + 300;
                            }
                            else
                            {
                                results = results + 500;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {

                            results = results + 500;
                        }
                        break;
                    case 'M':
                        try
                        {
                            if (numeralsBroken[n - 1] == 'C')
                            {
                                results = results + 800;
                            }
                            else
                            {
                                results = results + 1000;
                            }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            results = results + 1000;
                        }

                        break;
                }
            }

            return results;
        }
    }
}
