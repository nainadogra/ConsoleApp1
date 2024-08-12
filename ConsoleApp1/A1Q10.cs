using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q10
    {
        public static void dataset()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };

            int[] commonElements = FindCommonElements(dataset1, dataset2);

            Console.WriteLine("Common elements:");
            foreach (int element in commonElements)
            {
                Console.WriteLine(element);
            }
        }

        static int[] FindCommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonList = new List<int>();
            foreach (int element in arr1)
            {
                if (Array.Exists(arr2, e => e == element))
                {
                    commonList.Add(element);
                }
            }

            return commonList.ToArray();
        }
    }

}
