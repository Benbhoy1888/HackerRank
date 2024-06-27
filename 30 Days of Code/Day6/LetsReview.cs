using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string odds = "";
            string evens = "";

            string s = Console.ReadLine();

            for (int j = 0; j < s.Length; j++)
            {
                switch (j % 2)
                {
                    case 0:
                        evens += s[j];
                        break;

                    case 1:
                        odds += s[j];
                        break;
                }
            }
            Console.WriteLine(evens + " " + odds);
        }
    }

}