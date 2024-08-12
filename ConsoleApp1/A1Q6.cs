using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q6
    {
        public static void Search()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };

            int start = 0;
            int end = searchHistory.Length - 1;

            while (start < end)
            {
                // swap elements at start and end indices
                int temp = searchHistory[start];
                searchHistory[start] = searchHistory[end];
                searchHistory[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("Reversed search history:");
            foreach (int item in searchHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
