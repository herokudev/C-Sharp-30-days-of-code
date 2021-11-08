using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string aDate = Console.ReadLine();
            string eDate = Console.ReadLine();

            string[] actDate = aDate.Split(' ');
            string[] expDate = eDate.Split(' ');

            int actDay = int.Parse(actDate[0]);
            int actMonth = int.Parse(actDate[1]);
            int actYear = int.Parse(actDate[2]);

            int expDay = int.Parse(expDate[0]);
            int expMonth = int.Parse(expDate[1]);
            int expYear = int.Parse(expDate[2]);

            int charges = 0;

            if ((actDay <= expDay) && (actMonth <= expMonth) && (actYear <= expYear)) Console.WriteLine(charges);
            else
            {
                if (actYear > expYear) charges = 10000;
                else
                {
                    if ((actYear == expYear) && (actMonth > expMonth)) charges = 500 * (actMonth - expMonth);
                    else
                    {
                        if ((actYear == expYear) && (actMonth == expMonth) && (actDay > expDay)) charges = 15 * (actDay - expDay);
                    }
                }
                Console.WriteLine(charges);
            }

    }
}
