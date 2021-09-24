using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static bool checkNumber(int myNumber)
    {
        bool isOdd_number = false;
        int rem = myNumber % 2;
        isOdd_number = rem != 0;
        return isOdd_number;

    }

    static void processArray(string[] sTest)
    {

        foreach (string s in sTest)
        {
            int cIndex = 0;
            string evenChars = "";
            string oddChars = "";

            foreach (char c in s)
            {
                if (checkNumber(cIndex)) oddChars = oddChars + c;
                else evenChars = evenChars + c;
                cIndex++;
            }
            Console.WriteLine(evenChars + " " + oddChars);
        }
    }

    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        string[] mytest = new string[T];
        for (int i = 0; i < T; i++)
        {
            mytest[i] = Console.In.ReadLine();
        }
        processArray(mytest);
    }
}
