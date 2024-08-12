using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q1
    {
        public static void xyz()
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int totalSum = 0;

            foreach (int transaction in transactions)
            {
                totalSum += transaction;
            }

            Console.WriteLine("The total sum of transactions is: " + totalSum);

            // Wait for the user to press Enter before closing the console window
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }


}

