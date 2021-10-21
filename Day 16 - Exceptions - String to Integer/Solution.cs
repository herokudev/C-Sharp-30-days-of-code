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
        string s = Console.ReadLine();
        try
        {
            int num = Int32.Parse(s);
            Console.Write(num);
        }
        catch (Exception)
        {
            Console.Write("Bad String");
        }

    }
}
