using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int N = int.Parse(Console.ReadLine());
        
        string search;
        
        Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
        
        for (int i = 0; i < N; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            string name = data[0];
            string phoneNumber = data[1];
            PhoneBook[name] = phoneNumber;
        }
        
        while ((search = Console.ReadLine()) != null)
        {
           if (PhoneBook.TryGetValue(search, out string phoneNumber))
           {
               Console.WriteLine(search + "=" + phoneNumber);
           }
           
           else
           {
               Console.WriteLine("Not found");
           }
        }    
    }
}