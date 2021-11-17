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

    public static void maxBitwise(string[] testData)
    {
        int testCases = testData.Length;

        for (int index = 0; index < testCases; index++)
        {
            string[] nk = testData[index].Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] sNumbers = new int[n];
            List<int> bitwiseNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                sNumbers[i - 1] = i;
            }

            int indexA = 0;
            int indexB = 1;

            while (indexA < n)
            {
                while (indexB <= n - 1)
                {
                    //Console.WriteLine(sNumbers[indexA] + ", " + sNumbers[indexB]);
                    int c = sNumbers[indexA] & sNumbers[indexB];
                    if (c < k) bitwiseNumbers.Add(c);
                    indexB++;
                }
                indexA++;
                indexB = indexA + 1;
            }

            var resultData = bitwiseNumbers.ToArray();

            Array.Sort(resultData);
            Console.WriteLine(resultData[resultData.Length - 1]);

        }
    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());
        string[] testData = new string[t];

        for (int tItr = 0; tItr < t; tItr++)
        {
            string nk = Console.ReadLine();

            testData[tItr] = nk;
        }

        maxBitwise(testData);

    }
}
