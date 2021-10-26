using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int mod = 0;
        int result = 0;

        int[] numDivisors = new int[1000];
        for (int i = 1; i <= n; i++)
        {
            mod = n % i;
            if (mod == 0) numDivisors[i - 1] = i;
        }

        foreach (int x in numDivisors)
        {
            result = result + x;
        }

        return result;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}