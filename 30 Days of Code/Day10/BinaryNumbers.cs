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
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        string binary = Convert.ToString(n, 2);
        
        int max = findMax(binary);
        
        Console.WriteLine(max);
    }
    
    static int findMax(string binary)
    {
        int tempCount = 0;
        int maxCount = 0;
        
        foreach (char c in binary)
        {
            if (c == '1')
            {
                tempCount++;
                
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                }
            }
            
            else
            {
                tempCount = 0;
            }
        }
        
        return maxCount;
    }
}