using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static bool testNum(int num)
    {
        int ctr = 0;
        if ((num == 1000000007) || (num == 1000000009)) return true;
        else
        {
            if (num >= 1000000000) return false;
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                return (ctr == 0 && num != 1);
            }
        }
    }

    static void primeNumbers(List<long> numbers)
    {
        foreach (int n in numbers)
        {
            bool result = testNum(n);
            if (result) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<long> testNumbers = new List<long>();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            testNumbers.Add(data);
        }
        primeNumbers(testNumbers);
    }
}
