using System;

namespace Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string input = "~O~O~O~O P";
            // string input = "P O~ O~ ~O O~";
            string input = "~O~O~O~OP~O~OO~";

            int q = CountDeafRats(input);

            Console.WriteLine($"Wrong direction : {q}");
        }

        public static int CountDeafRats(string town)
        {
            int d = 0;
            int ppLocation = town.IndexOf("P");
            town = town.Replace(" ", "");
            string[] splitPP = town.Split("P");

            //TODO! LOOP THROUGH THE splitPP first half then second half to determine if it's left or right of PP.

            foreach (var m in splitPP)
            {
                int t = 0;
                // TODO GET THE SPLIT STRING AND THEN WORK OUT IF IT'S THE RIGHT WAY OR THE WRONG WAY

                Console.WriteLine($"ppLocation {ppLocation} splitPP Length {splitPP.Length}");

                char[] q = m.ToCharArray();

                 if (t == 0 && ppLocation == 0 && splitPP.Length == 1){
                    for (int i = 0; i < q.Length; i += 2)
                    {
                        Console.WriteLine($" pp @ 1 {q[i]}");
                        if (q[i].ToString() == "~")
                        {
                            d++;
                        }
                    }
                }
                else if (t == 0 && ppLocation > 0 && splitPP.Length == 1)
                {
                    for (int i = 0; i < q.Length; i += 2)
                    {
                        Console.WriteLine($" < p big {q[i]}");
                        if ((q[i].ToString() == "O") || (q[i].ToString() == "0"))
                        {
                            d++;
                        }
                    }
                }
                else if (t == 1 && ppLocation == 0 && splitPP.Length > 1)
                {
                    for (int i = 0; i < q.Length; i += 2)
                    {
                        Console.WriteLine($" > {q[i]}");
                        if ((q[i].ToString() != "0" || q[i].ToString() != "O"))
                        {
                            d++;
                        }
                    }
                }


                t++;
            }

            // string newString = $"{splitPP[0]}{splitPP[1]}";
            // char[] charString = newString.ToCharArray();

            // for (int i = 0; i < charString.Length; i += 2)
            // {
            //     Console.WriteLine($"{charString[i]}{charString[i+1]} String: {charString[i].ToString()} Location: {i} / {ppLocation} {charString}");

            //     if ((charString[i].ToString() == "0" || charString[i].ToString() == "O") && (i > ppLocation))
            //     {
            //         d++;

            //     }
            //     else if ((charString[i].ToString() == "~") && (i > ppLocation))
            //     {
            //         d++;
            //     }
            // Console.WriteLine($"dur {d}");
            // }

            return d;
        }
    }
}
