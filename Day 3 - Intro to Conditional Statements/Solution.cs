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
    static bool checkNumber(int myNumber)
    {
        bool isOdd_number = false;
        int rem = myNumber % 2;
        isOdd_number = rem != 0;
        return isOdd_number;

    }

    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        bool isOdd = checkNumber(N);

        if (isOdd) Console.WriteLine("Weird");
        else
        {
            if ((N >= 2) && (N <= 5))
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                if ((N >= 6) && (N <= 20))
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    if (N > 20) Console.WriteLine("Not Weird");
                }
            }
        }
    }
}