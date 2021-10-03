using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            string[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToString(arrTemp));
            phoneBook.Add(arr[0], arr[1]);
        }

        string query = "";
        while (true)
        {
            query = Console.ReadLine();
            if (query == null) break;
            try
            {
                Console.WriteLine(query + "=" + phoneBook[query]);
            }
            catch
            {
                Console.WriteLine("Not found");
            }
        }

    }
}