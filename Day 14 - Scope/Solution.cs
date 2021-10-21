using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;
    private int numCount = 0;

    public Difference(int[] numbers)
    {
        elements = numbers;
        maximumDifference = 0;
    }

    public void computeDifference()
    {
        int diff = 0;
        numCount = elements.Length;
        for (int i = 0; i < numCount; i++)
        {
            foreach (int x in elements)
            {
                diff = Math.Abs(elements[i] - x);
                if (diff > maximumDifference) maximumDifference = diff;
            }
        }
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}