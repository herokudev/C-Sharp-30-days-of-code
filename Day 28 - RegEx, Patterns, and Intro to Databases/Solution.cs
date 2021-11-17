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



    static void Main(string[] args)
    {
        List<string[]> data = new List<string[]>();

        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            String myRegExString = "@gmail.com$";
            String myString = emailID;

            var match = Regex.Match(myString, myRegExString, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                data.Add(firstNameEmailID);
            }
        }

        int countNames = data.Count;
        string[] names = new string[countNames];
        int i = 0;
        foreach (string[] d in data)
        {
            names[i] = d[0];
            i++;
        }
        Array.Sort(names);

        foreach (string s in names)
        {
            Console.WriteLine(s);
        }

    }
}
