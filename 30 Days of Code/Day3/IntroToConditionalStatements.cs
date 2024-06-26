using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        if (N >= 1 && N <= 100)
        {
            switch (N % 2)
            {
                case 0:
                    if (N >= 2 && N <= 5)
                    {
                        Console.WriteLine("Not Weird");
                        break;
                    }

                    else if (N >= 6 && N <= 20)
                    {
                        Console.WriteLine("Weird");
                        break;
                    }

                    else if (N > 20)
                    {
                        Console.WriteLine("Not Weird");
                        break;
                    }

                    break;

                case 1:
                    Console.WriteLine("Weird");
                    break;
            }
        }

    }
}
