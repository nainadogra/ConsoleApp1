using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q2
    {
        public static void average()
        {
            float[] score = { 85, 5f, 99, 3f, 78, 4f, 88, 9f, 92.1f };
            float sum = 0;
            float avg = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            avg = sum /score.Length;
            Console.WriteLine("total sum:" + sum);
            Console.WriteLine("average: " + avg);
        }
    }
}
