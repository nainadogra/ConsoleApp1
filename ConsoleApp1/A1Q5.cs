using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q5
    {
        public static void Measurement()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("Original measurements:");
            foreach (int item in measurements)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
            }

            Console.WriteLine("Adjusted measurements (multiplied by " + factor + "):");
            foreach (int item in measurements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
