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
        String number = "1101";
        int fromBase = 10;
        int toBase = 2;

        number = n.ToString();
        String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        //Console.WriteLine(result);
        char[] myTest = result.ToCharArray();

        int xMin = 0;
        int xMax = 0;
        foreach (char c in myTest)
        {
            if (c == '1') xMax++;
            else
            {
                if (xMin <= xMax) xMin = xMax;
                xMax = 0;
            }
        }
        if (xMax <= xMin) xMax = xMin;
        Console.WriteLine(xMax);
    }
}
