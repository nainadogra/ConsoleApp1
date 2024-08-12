using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q8
    {
        public static void grades()
        {
            int[] grades = { 56, 78, 89, 45, 67 };

            Array.Sort(grades);

            int secondSmallest = FindSecondSmallest(grades);

            Console.WriteLine("The second smallest grade is " + secondSmallest);
        }

        static int FindSecondSmallest(int[] sortedGrades)
        {
            if (sortedGrades.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements");
            }

            return sortedGrades[1];
        }
    }
}
